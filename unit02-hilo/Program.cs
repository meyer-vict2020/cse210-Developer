using System;

namespace unit02_hilo
{
    class Card
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            int card = 5;
            int nextCard = 0;
            string userInput = "";
            int score = 100;

            while(playAgain)
            {
                //print the current card
                Console.WriteLine($"\nThe card is: {card}");
                //ask user to input h or l
                userInput = getUserInput(userInput);
                //update the new card and print it
                nextCard = updateCard(nextCard);
                //update the score and print it
                score = updateScore(score, userInput, card, nextCard);
                card = nextCard;
                //ask user if they want to play again
                playAgain = checkPlayAgain(playAgain);

                
            }
            
        }
        
        static string getUserInput(string userInput){
            Console.Write($"Higher or lower? [h/l] ");
            userInput = Console.ReadLine();
            return userInput;
        }

        static int updateCard(int nextCard){
            Random newCard = new Random();
            nextCard = newCard.Next(1,14);
            Console.WriteLine($"Next card was: {nextCard}");
            return nextCard;
        }

        static int updateScore(int score, string userInput, int card, int nextCard){
            if (userInput == "h"){
                if (nextCard > card){
                    score += 100;
                }
                else{
                    score -= 75;
                }
            }
            else if (userInput == "l"){
                if(nextCard < card){
                    score += 100;
                }
                else{
                    score -= 75;
                }
            }
            
            Console.WriteLine($"Your score is: {score}");
            return score;
        }

        static bool checkPlayAgain(bool playAgain){
            Console.Write("Do you want to play again? [y/n] ");
            string userInput = Console.ReadLine();
            if (userInput == "y"){
                playAgain = true;
            }
            else if(userInput == "n"){
                playAgain = false;
            }
            return playAgain;
        }
    }
}
