using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int NumTickets = Convert.ToInt32(Console.ReadLine());
            bool qualify = age >= 15 && NumTickets <= 3 && !DUI;
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualify);
            Console.Read();
        }
    }
}
