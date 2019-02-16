using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee : Person, IQuittable
    {
        public int ID { set; get; }

        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("\r\nGoodbye");
            Console.ReadKey();
        }

        public static bool operator== (Employee a, Employee b)
        {
            if (a.ID == b.ID) return true;
            else return false;
        }
        public static bool operator!= (Employee a, Employee b)
        {
            if (a.ID != b.ID) return true;
            else return false;
        }
    }
}
