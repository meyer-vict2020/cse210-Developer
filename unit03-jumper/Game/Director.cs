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
        private Parachute _parachute = new Parachute();
        private TerminalService terminalService = new TerminalService();

        private List<char> _guessed = new List<char>();
        private bool _isPlaying = true;
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
            while (_isPlaying)
            {
                DoOutputs();
                GetInputs();
                //prevents the updates and gets another guess if the letter has already been guessed
                while (_guessed.Contains(guess)){
                    terminalService.WriteText($"You have already _guessed '{guess}.' Please guess again.");
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
            //add the guess to the list of _guessed words
            _guessed.Add(guess);
            _parachute.UpdateParachute(guess, word.answer);
            word.UpdateWord(guess);

            //if the word is completed, end the game
            if (word.isWon()){
                endGame();
                terminalService.WriteText("\nYou have won!");
            }
            //if the parachute is gone, end the game
            else if (_parachute.isLost()){
                endGame();
                terminalService.WriteText("\nYou have Lost.");
            }
        }

        /// <summary>
        /// Displays the current parachute and word
        /// </summary>
        private void DoOutputs()
        {
            _parachute.DisplayParachute();
            word.DisplayWord();
        }

        ///<summary>
        /// Displays the final end parachute and word and 
        /// ends the game.
        ///</summary>
        private void endGame(){
            _isPlaying = false;
            _parachute.DisplayParachute();
            word.DisplayWord();            
        }
    }
}