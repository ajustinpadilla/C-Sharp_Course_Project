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
            Console.Read();
        }
    }
}
