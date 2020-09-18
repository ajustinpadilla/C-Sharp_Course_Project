using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecifyParameters
{
    class Program
    {
        static void Main()
        {
            Math nums = new Math();

            nums.OptionalParam(2, 17);
            nums.OptionalParam(num1: 71, num2: 25);
            Console.ReadLine();
        }
    }
}
