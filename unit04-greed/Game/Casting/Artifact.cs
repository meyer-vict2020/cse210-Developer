using System;

namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide a message about itself.
    /// </para>
    /// </summary>
    public class Artifact : Actor
    {
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact()
        {
        }


        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public void GetScore(){

        }


        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        public int ChangeScore(int score){
            score = score + 1;
            return score;
        }
    }
}