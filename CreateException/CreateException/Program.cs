using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateException
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            int age = 0;
            try
            {
                while (!validAnswer)
                {
                    Console.WriteLine("What's your age?");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }
                if (age < 1)
                {
                    throw new InvalidAgeException();
                }

            }
            catch (InvalidAgeException)
            {
                Console.WriteLine("That is not a valid age. Please give an age above 0.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please try again later");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("You were born in {0}",DateTime.Now.Year - age);
            Console.ReadLine();
        }
    }
}
