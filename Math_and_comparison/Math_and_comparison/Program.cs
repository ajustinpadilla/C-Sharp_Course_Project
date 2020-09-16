using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_comparison
{
    class Program
    {
        static void Main()
        {
			Console.WriteLine("Anonymous Income Comparison Program");
			Console.WriteLine("Peson 1");
			Console.WriteLine("Hourly Rate?");
			int hourlyRate1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Hours Worked per week?");
			int hoursWorked1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Peson 2");
			Console.WriteLine("Hourly Rate?");
			int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Hours Worked per week?");
			int hoursWorked2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Annual salary of person 1:");
			int P1Salary = hourlyRate1 * hoursWorked1 * 52;
			Console.WriteLine(P1Salary);
			Console.WriteLine("Annual salary of person 2:");
			int P2Salary = hourlyRate2 * hoursWorked2 * 52;
			Console.WriteLine(P2Salary);
			bool Comparison = P1Salary > P2Salary;
			Console.WriteLine("Does Person 1 make more money than Person 2?");
			Console.WriteLine(Comparison);
			Console.Read();
		}
    }
}
