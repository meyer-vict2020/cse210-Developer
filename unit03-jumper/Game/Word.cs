using System;
using System.Collections.Generic;
using System.IO;

namespace Unit03.Game
{
    /// <summary>
    /// The purpose of the Word class is to create a new
    /// answer, display the blank word, and update the word
    /// based on if the guesses are in the answer.
    /// </summary>
    public class Word
    {
        public List<char> word = new List<char>();
        public string answer;

        /// <summary>
        /// Constructs a new instance of Word.
        /// </summary>
        public Word(){
            Random random = new Random();
            //choose a random word from a list for the answer
            List<string> randWord = new List<string>(File.ReadLines("Words.txt"));
            int randomIndex = random.Next(0, randWord.Count);
            answer = randWord[randomIndex];
            
            //initiate the word with blanks
            foreach (char i in answer){
                word.Add('_');
            }
        } 

        /// <summary>
        /// Updates and displays the progress for the word
        /// </summary>
        public void DisplayWord(){
            foreach (char i in word){
                Console.Write($"{i} ");
            }
        }
        
        /// <summary>
        /// Checks whether the input is part of the answer
        /// and is valid, and updates the word
        /// </summary>
        public void UpdateWord(char guess){
            int i = 0;
            foreach (char c in answer){
                if (c == guess){
                    word[i]= guess;
                }
                i += 1;
            } 
        }

        /// <summary>
        /// Checks whether the word has been completed
        /// </summary>
        public bool isWon(){
            foreach (char c in word){
                if (c == '_'){
                    return false;
                }
            }
            return true;
        }

    }
}