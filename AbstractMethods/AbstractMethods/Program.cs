
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
            IQuittable quit = new Employee<string>();
            Employee<string> Sample = new Employee<string>() { lastName = "Student", firstName = "Sample", Id = 1 };
            Sample.things = new List<string>() { "item 1", "item 2", "item 3", "item 4" };
            Employee<int> Angel = new Employee<int>() { firstName = "Angel", lastName = "Padilla", Id = 2 };
            Angel.things = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Sample.SayName();
            quit.Quit();
            foreach(int thing in Angel.things) { Console.WriteLine(thing); }
            foreach(string thing in Sample.things) { Console.WriteLine(thing); }
            Console.ReadLine();
        }
    }
}
