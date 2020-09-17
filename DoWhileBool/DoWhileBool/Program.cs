using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileBool
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many people do I have in my family");
            int NumGuess = Convert.ToInt32(Console.ReadLine());
            bool keepGoing = NumGuess == 6;


            do
            {
                switch (NumGuess)
                {
                    case 6:
                        Console.WriteLine("You guessed correctly! I do have 6 people in my family");
                        keepGoing = true;
                        break;
                    default:
                        Console.WriteLine("You guessed " + NumGuess + ". That is incorrect! Please try again.");
                        Console.WriteLine("How many people do I have in my family");
                        NumGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!keepGoing);

            Console.WriteLine("\nHow many animals are in the zoo?");
            int animalGuess = Convert.ToInt32(Console.ReadLine());
            bool keepGoing1 = true;

            while (keepGoing1)
            {
                switch(animalGuess)
                {
                    case 15:
                        Console.WriteLine("You guessed " + animalGuess + ". That's correct!! Thank you for playing");
                        keepGoing1 = false;
                        break;

                    default:
                        Console.WriteLine("You guessed " + animalGuess + ". That is incorrect! Please try again.");
                        Console.WriteLine("\nHow many animals are in the zoo?");
                        animalGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.Read();
        }
    }
}
