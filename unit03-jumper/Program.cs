using System;
using Unit03.Game;

namespace unit03_jumper
{
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}
