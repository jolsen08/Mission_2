using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Jacob Olsen, Section 3
namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] rollTotals = new int[13];

            int TimesThrown = 0;

            //Having the console display the appropriate messages.
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine();
            Console.Write("How many dice rolls would you like to simulate? ");
            TimesThrown = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");           
            Console.WriteLine("Total number of rolls = " + TimesThrown + ".\n");
           
            rollTotals[0] = r.Next(6);

            //Simulate the roll of the die
            for (int i = 0; i < TimesThrown; i++)
            {
                int roll1 = r.Next(1,7);
                int roll2 = r.Next(1,7);

                int rollTots = roll1 + roll2;

                rollTotals[rollTots]++;
            }

            //Print out the results from the array along with the concluding message.
            for (int i = 2; i <= 12; i++)
            {
                int Percentage = (int)((double)rollTotals[i] / TimesThrown * 100);
                Console.Write(i + ": ");

                for (int j = 0; j < Percentage; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
