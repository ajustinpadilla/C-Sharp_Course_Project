﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Sample = new Employee() { FirstName = "Sample", LastName = "Student" };
            Sample.SayName();
            Console.Read();
        }
    }
}
