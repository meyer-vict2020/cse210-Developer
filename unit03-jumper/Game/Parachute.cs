using System;
using System.Collections.Generic;

namespace Unit03.Game 
{
    /// <summary>
    /// The purpose of the Parachute is to save the jumper.
    /// The player has to guess the correct word before
    /// the parachute runs out.
    /// </summary>
    public class Parachute
    {
        private List<string> _parachute = new List<string>();

        /// <summary>
        /// Constructs a new instance of the Parachute. 
        /// </summary>
        public Parachute()
        {
            _parachute.Add(@"  ____    ");
            _parachute.Add(@" /    \   ");
            _parachute.Add(@"/______\ ");
            _parachute.Add(@"\      /");
            _parachute.Add(@" \    / ");
            _parachute.Add(@"  \  /  ");
            _parachute.Add(@"    o ");
            _parachute.Add(@"   /|\ ");
            _parachute.Add(@"   / \ ");
        }
        
        /// <summary>
        /// Displays the current progress with the parachute
        /// </summary>
        public void DisplayParachute()
        {
            string para = string.Join("\n", _parachute);
            Console.WriteLine(para);
        }

        /// <summary>
        /// Updates the parachute based on whether the user 
        /// inputs a correct letter.
        /// </summary>
        public void UpdateParachute(char guess, string answer)
        {
            if (answer.Contains(guess)){
                return;
            }
            else{
                _parachute.RemoveAt(0);
            }
        }

        ///<summary>
        /// If the parachute is gone, then you have lost the game
        ///</summary>
        public bool isLost()
        {
            if (_parachute.Count <= 3){
                _parachute[0] = "    x   ";
                return true;
            }
            else{
                return false;
            }
        }
    }
}