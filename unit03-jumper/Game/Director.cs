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
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetInputs()
        {
            string userInput = terminalService.ReadText("Guess a letter [a-z]: ");

        }

        /// <summary>
        /// 
        /// </summary>
        private void DoUpdates()
        {
            parachute.UpdateParachute();
            word.CheckAnswer();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DoOutputs()
        {
            parachute.DisplayParachute();
            
        }
    }
}