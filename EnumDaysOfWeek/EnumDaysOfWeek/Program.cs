using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDaysOfWeek
{
    class Program
    {
        static void Main()
        {
            try
            {
            Console.Write("What day of the week is it?\n>>>");
            Days day = (Days)Enum.Parse(typeof(Days), Console.ReadLine());
            Console.WriteLine("You said it is {0}!!", day);

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            
            

            Console.ReadLine();


        }

        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
