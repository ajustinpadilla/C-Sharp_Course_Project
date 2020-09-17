using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageBranching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instuctions below.");
            Console.WriteLine("Please enter package weight:");
            int PackageWeight = Convert.ToInt32(Console.ReadLine());
            if (PackageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter Package width:");
                int PackageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Package height:");
                int PackageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Package length:");
                int PackageLength = Convert.ToInt32(Console.ReadLine());
                int PackageVolume = PackageWidth * PackageHeight * PackageLength;
                int PackageDemSum = PackageWidth + PackageLength + PackageHeight;
                if (PackageDemSum > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int ShipQuote = (PackageVolume * PackageWeight) / 100;
                    Console.WriteLine("Your estimated total to ship this package is: $" + ShipQuote);
                    Console.WriteLine("Thank You!");
                    Console.Read();
                }
            }
        }
    }
}
