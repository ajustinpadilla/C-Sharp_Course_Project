using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteToAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number.\n>>>");
            string num = Console.ReadLine();
            File.WriteAllText(@"C:\C-Shrap_Course\logs\WrittenFile.txt", "your number: " + num);
            Console.WriteLine(File.ReadAllText(@"C:\C-Shrap_Course\logs\WrittenFile.txt"));
            Console.ReadLine();
        }
    }
}
