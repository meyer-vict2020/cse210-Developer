using System;
using unit02_hilo;

namespace unit02_hilo
{
    public class Director{
        public bool playAgain = true;
        public string userInput = "";
        Card card = new Card();

        public Director(){
        }
        
        ///<summary>
        /// starts the game
        ///</summary>
        public void startGame(){
            while(playAgain && card.score > 0)
            {
                //print the current card
                Console.WriteLine($"\nThe card is: {card.currCard}");
                //ask user to input h or l
                userInput = getUserInput(userInput);
                //update the new card and print it
                card.nextCard = card.updateCard(card.nextCard);
                //update the score and print it
                card.score = card.updateScore(card.score, userInput, card.currCard, card.nextCard);
                card.currCard = card.nextCard;
                //ask user if they want to play again
                if(card.score > 0){
                    playAgain = card.checkPlayAgain(playAgain);
                }
            }
            gameOver(card.score);
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
        /// Once the game is over, thank the player for playing
        /// </summary>
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