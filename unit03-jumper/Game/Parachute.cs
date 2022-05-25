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
        private List<string> parachute = new List<string>();

        /// <summary>
        /// Constructs a new instance of the Parachute. 
        /// </summary>
        public Parachute()
        {
            parachute.Add(@"  ____    ");
            parachute.Add(@" /    \   ");
            parachute.Add(@"/______\ ");
            parachute.Add(@"\      /");
            parachute.Add(@" \    / ");
            parachute.Add(@"  \  /  ");
            parachute.Add(@"    o ");
            parachute.Add(@"   /|\ ");
            parachute.Add(@"   / \ ");
        }
        
        /// <summary>
        /// Displays the current progress with the parachute
        /// </summary>
        public void DisplayParachute()
        {
            string para = string.Join("\n", parachute);
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
                parachute.RemoveAt(0);
            }
        }

        ///<summary>
        /// If the parachute is gone, then you have lost the game
        ///</summary>
        public bool isLost()
        {
            if (parachute.Count <= 3){
                parachute[0] = "    x";
                return true;
            }
            else{
                return false;
            }
        }
    }
}