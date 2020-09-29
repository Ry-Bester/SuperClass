using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClass
{
   public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Joe";
            employee.LastName = "Blow";
            employee.Id = 1;
            Employee employee1 = new Employee();
            employee1.FirstName = "Billy";
            employee1.LastName = "Bob";
            employee1.Id = 2;
            employee.SayName();
            Console.WriteLine(employee == employee1);
            Console.WriteLine(employee != employee1);
            Console.ReadLine();
        }
    }
}
