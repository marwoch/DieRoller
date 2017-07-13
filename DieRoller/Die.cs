using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// A single 6 sided standard die
    /// </summary>
    class Die
    {
        static Random rand;
        /// <summary>
        /// Creates a Die object with a random value
        /// </summary>
        public Die()
        {
            Roll();
        }

        //runs once to initialize Random
        //to be shared for all Die objects
        static Die()
        {
            rand = new Random();
        }

        /// <summary>
        /// Gets the value of the face-up side of the Die
        /// </summary>
        public byte Value { get; private set; }

        public bool IsHeld { get; set; }

        /// <summary>
        /// Generates a random number between 1 and 6 INCLUSIVE
        /// and sets the Die value
        /// </summary>
        /// <returns>Returns randomly generated value</returns>
        public byte Roll()
        {
            if (!IsHeld == false)
            {
                Value = (byte)rand.Next(1, 7);
            }
            Value = (byte)rand.Next(1,7);
            return Value;
        }

    }

    /// <summary>
    /// Represents 5 individual Die
    /// </summary>
    class Dice
    {
        List<Die> dice;
        const byte NumberOfDie = 5;
        public Dice()
        {
            dice = new List<Die>(5);
            for (int i = 1; i <= NumberOfDie; i++)
            {
                dice.Add(new Die());
            }
        }

        public List<Die> AllDice
        {
            get { return dice; }
        }

        /// <summary>
        /// Rolls all dice
        /// </summary>
        public void Roll()
        {
            foreach(Die d in dice)
            {
                d.Roll();
            }
        }
    }
}
