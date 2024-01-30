using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Collectios
{
    internal class EmployeeDetails
    {
        static void Main() 
        {
            SortedDictionary<int, string> employeeDetails = new SortedDictionary<int, string>();
            employeeDetails.Add(12333, "HariSankar");
            employeeDetails.Add(93539, "Adithya");
            employeeDetails.Add(13455, "Aromal");
            employeeDetails.Add(23554, "Akash");

            Console.WriteLine("Employee Details");
            foreach(var k in employeeDetails.Keys)
            {
                Console.WriteLine($"{k} :{employeeDetails[k]} ");
            }

        
        }
    }
}
