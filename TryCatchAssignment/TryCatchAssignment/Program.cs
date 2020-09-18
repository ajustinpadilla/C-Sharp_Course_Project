using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main()
        {
            List<int> dividedNums = new List<int>() { 2, 22, 300, 200, 15, 17 };
            Console.WriteLine("Here are some numbers that you'll be dividing: ");
            int index = 0;
            foreach(int num in dividedNums)
            {
                if (index < (dividedNums.Count - 1))
                {
                    Console.Write(num + ", ");
                }

                else
                {
                    Console.Write(num + "\n");
                }
                index++;
            }
            Console.Write("\nWhat number would you like to divide them by?\n>>>");


            try
            {

                int divideby = Convert.ToInt32(Console.ReadLine());
                index = 0;
                Console.WriteLine("Here is the results of dividing by " + divideby + ":");

                foreach (int num in dividedNums)
                {
                    int results = num / divideby;


                    if (index < (dividedNums.Count - 1))
                    {
                        Console.Write(results + ", ");
                    }

                    else
                    {
                        Console.Write(results + "\n");
                    }
                    index++;

                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nCan't divide by zero. Please enter a whole number.");
            }

            catch(FormatException)
            {
                Console.WriteLine("\nPlease enter a whole number.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("\n" + ex);
            }
            finally
            {
                Console.WriteLine("\nPlease re-open the program and try again. Thank you!");
            }
            Console.ReadLine();
        }
    }
}
