using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What number would you like to use?");
            int specialNum = Convert.ToInt32(Console.ReadLine());
            int multiFifty = specialNum * 50;
            int addTwentyFive = specialNum + 25;
            double divide = specialNum / 12.5;
            bool gthan = specialNum > 50;
            int remainder = specialNum % 7;
            Console.WriteLine(specialNum + " multiplied by 50: " + multiFifty);
            Console.WriteLine(specialNum + " plus 25 is: " + addTwentyFive);
            Console.WriteLine(specialNum + " divided by 12.5 is: " + divide);
            Console.WriteLine("Is it true that " + specialNum + " greater than 50?: " + gthan);
            Console.WriteLine("When dividing " + specialNum + " by 7 you get a remainder of " + remainder);
            Console.Read();
        }
    }
}
