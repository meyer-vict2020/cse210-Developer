using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        public Word word = new Word();
        private Parachute parachute = new Parachute();
        private TerminalService terminalService = new TerminalService();

        private List<char> guessed = new List<char>();
        private bool isPlaying = true;
        public char guess;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                DoOutputs();
                GetInputs();
                //prevents the updates if the letter has already been guessed
                while (guessed.Contains(guess)){
                    terminalService.WriteText($"You have already guessed '{guess}.' Please guess again.");
                    GetInputs();
                }
                DoUpdates(guess);
            }
        }

        /// <summary>
        /// Gets the user guess and converts it to a character
        /// </summary>
        private void GetInputs()
        {
            string userInput = terminalService.ReadText("\nGuess a letter [a-z]: ");
            char[] guessArr = userInput.ToCharArray();
            guess = guessArr[0];
        }

        /// <summary>
        /// Updates the parachute and the word based on the guess
        /// </summary>
        private void DoUpdates(char guess)
        {
            //add the guess to the list of guessed words
            guessed.Add(guess);
            parachute.UpdateParachute(guess, word.answer);
            word.UpdateWord(guess);

            //if the word is completed, end the game
            if (word.isWon()){
                endGame();
                terminalService.WriteText("\nYou have won!");
            }
            //if the parachute is gone, end the game
            else if (parachute.isLost()){
                endGame();
                terminalService.WriteText("\nYou have Lost.");
            }
        }

        /// <summary>
        /// Displays the current parachute and word
        /// </summary>
        private void DoOutputs()
        {
            parachute.DisplayParachute();
            word.DisplayWord();
        }

        ///<summary>
        /// Displays the final end parachute and word and 
        /// ends the game.
        ///</summary>
        private void endGame(){
            isPlaying = false;
            parachute.DisplayParachute();
            word.DisplayWord();            
        }
    }
}