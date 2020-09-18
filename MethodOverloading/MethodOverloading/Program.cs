using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input a number:\n>>>");
            int Num = Convert.ToInt32(Console.ReadLine());

            Num = Math.Exec(Num);
            Console.WriteLine("Your new number:\n" + Num);

            Console.Write("\nInput another number:\n>>>");
            Decimal Num1 = Convert.ToDecimal(Console.ReadLine());

            Num1 = Math.Exec(Num1);
            Console.WriteLine("Your second new number:\n" + Num1);

            Console.Write("\nInput another number:\n>>>");
            string Num2 = Console.ReadLine();

            int Num3 = Math.Exec(Num2);
            Console.WriteLine("Your third new number:\n" + Num3);







            Console.ReadLine();
        }
    }
}
