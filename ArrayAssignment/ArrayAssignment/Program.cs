using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {
            string[] Names = { "Chris", "Phil", "John", "Rebecca", "Sharon" };
            int[] ages = { 19, 32, 39, 20, 17, 16, 25 };

            Console.WriteLine("Which name in the array do you choose?(0-4)");
            int arraySpot = Convert.ToInt32(Console.ReadLine());
            bool keepGoing = true;
            bool keepGoing1 = true;
            bool keepGoing2 = true;

            while (keepGoing)
            {
                if (arraySpot <= 4 && arraySpot >= 0)
                {
                    Console.WriteLine("You picked the name " + Names[arraySpot]);
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 0 and 4.");
                    Console.WriteLine("Which name in the array do you choose?(0-4)");
                    arraySpot = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("Pick a number in the array to choose a Age?(0-6)");
            int numSpot = Convert.ToInt32(Console.ReadLine());

            while (keepGoing1)
            {
                if (numSpot <= 6 && numSpot >= 0)
                {
                    Console.WriteLine("You picked the age " + ages[numSpot]);
                    keepGoing1 = false;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 0 and 6.");
                    Console.WriteLine("Pick a number in the array to choose a Age?(0-6)");
                    numSpot = Convert.ToInt32(Console.ReadLine());
                }

            }

            List<string> jobs = new List<string>()
            {
                "Photographer", "Mailman", "Teacher", "Policeman", "Firefighter", "Doctor", "Truck Driver" 
            };

            Console.WriteLine("Pick a number in the list to choose a Job?(0-6)");
            int listSpot = Convert.ToInt32(Console.ReadLine());

            while (keepGoing2)
            {
                if (listSpot <= 6 && listSpot >= 0)
                {
                    Console.WriteLine("You picked the Job " + jobs[listSpot]);
                    keepGoing2 = false;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 0 and 6.");
                    Console.WriteLine("Pick a number in the array to choose a Job?(0-6)");
                    listSpot = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.ReadLine();
        }
    }
}
