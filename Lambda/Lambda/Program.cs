using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main()
        {
            Employee frank = new Employee() { FirstName = "Frank", LastName = "Pual", Id = 1 };
            Employee joe1 = new Employee() { FirstName = "Joe", LastName = "Black", Id = 2 };
            Employee joe2 = new Employee() { FirstName = "Joe", LastName = "Mama", Id = 3 };
            Employee sally = new Employee() { FirstName = "Sally", LastName = "Sill", Id = 4 };
            Employee mike = new Employee() { FirstName = "Mike", LastName = "Ridge", Id = 5 };
            Employee zach = new Employee() { FirstName = "Zach", LastName = "Self", Id = 6 };
            Employee michael = new Employee() { FirstName = "Michael", LastName = "Cumberbatch", Id = 7 };
            Employee jake = new Employee() { FirstName = "Jake", LastName = "Garcia", Id = 8 };
            Employee angel = new Employee() { FirstName = "Angel", LastName = "Padilla", Id = 9 };
            Employee liz = new Employee() { FirstName = "Liz", LastName = "Huerta", Id = 10 };

            List<Employee> employees = new List<Employee>() { frank, joe1, joe2, sally, mike, zach, michael, mike, jake, angel, liz };
            List<Employee> newList = new List<Employee>();
            List<Employee> lambdaList = employees.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> greaterList = employees.Where(x => x.Id > 5).ToList();
            foreach(Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                }
            }

            foreach(Employee employee in newList) { employee.SayName(); }
            Console.WriteLine("\nNow from a lambda expression:\n");
            foreach(Employee employee in lambdaList) { employee.SayName(); }
            Console.WriteLine("\nNow lamda list with Id greater than 5:\n");
            foreach (Employee employee in greaterList) { employee.SayName(); }
            Console.ReadLine();
            


            
        }
    }
}
