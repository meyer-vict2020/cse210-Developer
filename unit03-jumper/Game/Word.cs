using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    /// <summary>
    /// 
    /// </summary>
    public class Word
    {
        public List<char> word = new List<char>();
        public string answer;
        private TerminalService terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Word.
        /// </summary>
        public Word(){
            Random random = new Random();
            string[] randWord = {"apple", "table", "waterbottle", "television", "sphynx"};
            int w = random.Next(0, 4);
            answer = randWord[w];

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