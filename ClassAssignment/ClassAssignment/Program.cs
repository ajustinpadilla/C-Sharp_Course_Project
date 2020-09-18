using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please choose a number:\n>>>");
            int num = Convert.ToInt32(Console.ReadLine());
            int added = Math.AddThree(num);
            int multi = Math.MultiThree(num);
            int sub = Math.SubThree(num);

            Console.WriteLine(num + " plus three equals:\n" + added);
            Console.WriteLine(num + " multiplied three equals:\n" + multi);
            Console.WriteLine(num + " subtracted three equals:\n" + sub);
            Console.ReadLine();
        }
    }
}
