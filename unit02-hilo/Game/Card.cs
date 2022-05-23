using System;

namespace unit02_hilo
{
    ///<summary>
    /// The Card class contains all variables and functions
    /// related to the hilo game
    ///</summary>
    public class Card
    {   
        public int currCard = 5;
        public int nextCard = 0;
        public int score = 100;

        ///<summary>
        /// creates a new instance of Card
        ///</summary>
        public Card(){
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
        public int updateScore(int score, string userInput, int currCard, int nextCard){
            //if the user guesses higher
            if (userInput == "h"&& nextCard >= currCard){    
                score += 100;
            }
            else if (userInput == "l" && nextCard <= currCard){
                score += 100;
            }
            else{
                score -= 75;
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

        
    }
}