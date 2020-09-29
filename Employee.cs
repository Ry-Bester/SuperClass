using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SuperClass
{
     public class Employee : Person
    {
        public int Id { get; set; }

        public static bool operator == (Employee obj1 , Employee obj2 )
        {
            bool result;
            if (obj1.Id == obj2.Id)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static bool operator != (Employee obj1, Employee obj2)
        {
            bool result;
            if (obj1.Id != obj2.Id)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
