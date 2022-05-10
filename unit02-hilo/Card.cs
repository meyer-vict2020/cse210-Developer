using System;

namespace unit02_hilo
{
    public class Card
    {
        
        public bool playAgain = true;
        //public Random newCard = new Random();
        public int card = 5;
        public int nextCard = 0;
        public string userInput = "";
        public int score = 100;

        public void startGame(){
            while(playAgain && score > 0)
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
                if(score > 0){
                    playAgain = checkPlayAgain(playAgain);
                }
            }
            gameOver(score);
        }
        
        /// <summary>
        ///Asks the user if their guess is higher or lower
        /// </summary>
        public string getUserInput(string userInput){
            Console.Write($"Higher or lower? [h/l] ");
            userInput = Console.ReadLine();
            return userInput;
        }

        /// <summary>
        /// Generates a random number between 1 and 13 for the
        /// new card and prints the new card value.
        /// </summary>
        public int updateCard(int nextCard){
            Random newCard = new Random();
            nextCard = newCard.Next(1,14);
            Console.WriteLine($"Next card was: {nextCard}");
            return nextCard;
        }

        /// <summary>
        /// Updates the score depending on the user input, current card, and
        /// the next card values. 
        /// If user guesses whether the next card value is higher or lower
        /// correctly, they gain 100 points. Otherwise, they will lose 75 points.
        /// </summary>
        public int updateScore(int score, string userInput, int card, int nextCard){
            //if the user guesses higher
            if (userInput == "h"){
                if (nextCard >= card){
                    score += 100;
                }
                else{
                    score -= 75;
                }
            }
            //if the user guesses lower
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

        /// <summary>
        /// Asks the user if they want to play again.
        /// </summary>
        public bool checkPlayAgain(bool playAgain){
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

        public void gameOver(int score){
            if (score> 0){
                Console.WriteLine($"\nThank you for playing.\nYour score is {score}");
            }
            if (score <= 0){
                Console.WriteLine("\nYou have lost. Thank you for playing.");
            }
        }
    }
}