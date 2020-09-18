using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodParameters
{
    class Program
    {
        static void Main()
        {
            Math doing = new Math();

            Console.WriteLine("Please enter two numbers.");
            Console.Write("First number:\n>>>");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number:\n(This is optional)>>>");
            string num2 = Console.ReadLine();
            int intNum2;
            int sum;
            if (num2 == "")
            {
                sum = doing.Add(num1);
            }
            else
            {
                intNum2 = Convert.ToInt32(num2);
                sum = doing.Add(num1, intNum2);
            }


            Console.Write("\nYour sum is:\n>>>" + sum);
            Console.ReadLine();

        }
    }
}
