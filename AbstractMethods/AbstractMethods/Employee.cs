using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods
{
     public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("I quit!");
        }

        public static bool operator==(Employee employee1, Employee employee2)
        {
            bool equal = employee1.Id == employee2.Id;
            return equal;
        }
        public static bool operator!=(Employee employee1, Employee employee2)
        {
            bool notEqual = employee1.Id != employee2.Id;
            return notEqual;
        }
    }
}
