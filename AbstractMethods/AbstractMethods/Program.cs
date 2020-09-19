
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Sample = new Employee() { lastName = "Student", firstName = "Sample" };
            Sample.SayName();
            Console.ReadLine();
        }
    }
}
