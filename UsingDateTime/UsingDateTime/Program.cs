using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please give me a number");
            double hours = Convert.ToDouble(Console.ReadLine());
            DateTime laterTime = DateTime.Now.AddHours(hours);
            Console.WriteLine("It will be {0} in {1} hours.", laterTime, hours);
            Console.ReadLine();
        }
    }
}
