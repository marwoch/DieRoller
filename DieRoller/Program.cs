using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDice = new Dice();

            DisplayDice(myDice);
            Console.WriteLine();
            myDice.Roll();
            DisplayDice(myDice);
            Console.WriteLine();


            Die myDie = new Die();
            Die myDie2 = new Die();
            Die myDie3 = new Die();

            Console.WriteLine(myDie.Value);
            Console.WriteLine(myDie2.Value);
            Console.WriteLine(myDie3.Value);

            Console.ReadKey();
        }

        private static void DisplayDice(Dice myDice)
        {
            foreach (Die d in myDice.AllDice)
            {
                Console.WriteLine(d.Value);
            }
        }
    }
}
