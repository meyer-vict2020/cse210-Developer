using System;
using System.Collections.Generic;

namespace Unit03.Game 
{
    /// <summary>
    /// 
    /// </summary>
    public class Parachute
    {
        List<string> parachute = new List<string>();

        /// <summary>
        /// Constructs a new instance of the Parachute. 
        /// </summary>
        public Parachute()
        {
            parachute.Add(@"  ____    ");
            parachute.Add(@" /____\ ");
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
        public void UpdateParachute(int guess)
        {

        }

        public bool isLost()
        {
            return true;
        }
    }
}