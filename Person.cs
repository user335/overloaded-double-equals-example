using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();

        static public List<Person> employees;
        static void Main()
        {
            employees = new List<Person>();
            var employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.ID = 1;
            employees.Add(employee);

            var employee2 = new Employee();
            employee2.firstName = "Sample2";
            employee2.lastName = "Student2";
            employee2.ID = 2;
            employees.Add(employee2);

            Console.WriteLine("Listing all employees: ");
            //for (int i = 0; i < employees.Count; i++)
            //{
            //    employees[i].SayName();
            //}
            foreach (var item in employees)
            {
                item.SayName();
            }

            Console.WriteLine("Does A == B? Answer : " + (employees[0] == employees[1]).ToString());
            Console.WriteLine("Does A != B? Answer : " + (employees[0] != employees[1]).ToString());
            Console.WriteLine("And there you have it.");

            Console.Read();

            IQuittable quitter = new Employee();
            quitter.Quit();
        }
    }
}
