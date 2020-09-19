using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main()
        {
            Multi output = new Multi();

            Console.Write("Please input a number:\n>>>");
            int num1 = Convert.ToInt32(Console.ReadLine());
            output.Half(num1, out int num2);
            Console.WriteLine("Your number was halfed: " + num2);
            Console.ReadLine();
        }
    }
}
