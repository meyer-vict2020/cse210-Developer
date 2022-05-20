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
        private char guess;
        private string answer;
        private TerminalService terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Word.
        /// </summary>
        public Word(){
            Random random = new Random();
            string[] randWord = {"apple", "table", "waterbottle", "television"};
            int w = random.Next(0, 4);
            answer = randWord[w];

            foreach (char c in answer){
                word.Add('_');
            }
        }

        /// <summary>
        /// Gets the user input for a letter
        /// </summary>
        public void GetGuess(){

        }
        
        /// <summary>
        /// Checks whether the input is part of the answer
        /// and is valid, and updates the word
        /// </summary>
        public void CheckAnswer(){
            
        }
    }
}