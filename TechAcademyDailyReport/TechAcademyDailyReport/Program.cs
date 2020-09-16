using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            String Name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            String CourseOn = Console.ReadLine();
            Console.WriteLine("What page number?");
            String Page = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool NeedHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            String SharedExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            String Feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            String StudyHours = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
