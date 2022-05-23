using System;

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
        private Word word = new Word();
        private Parachute parachute = new Parachute();
        private bool isPlaying = true;
        public char guess;
        private TerminalService terminalService = new TerminalService();

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
                DoUpdates();
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
        private void DoUpdates()
        {
            parachute.UpdateParachute(guess);
            word.UpdateWord(guess);
            if (word.isWon()){
                isPlaying = false;
                word.DisplayWord();
                terminalService.WriteText("\nYou have won!.");
            }
            if (parachute.isLost()){
                isPlaying = false;
                word.DisplayWord();
                terminalService.WriteText("\nYou have Lost. Try again later.");
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
    }
}