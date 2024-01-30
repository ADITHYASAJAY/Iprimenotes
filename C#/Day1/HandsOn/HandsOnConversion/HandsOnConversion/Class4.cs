using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Class4
    {
        static void Main() 
        {
            Console.WriteLine("Enter Employee name");
            string employeeName=Console.ReadLine();
            Console.WriteLine("Enter EmployeeId");
            int employeeId=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Gender");
            char employeeGender= Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Designation");
            string designation = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Employee Details");
            Console.WriteLine($"Name: {employeeName} Id:{employeeId} Gender:{employeeGender} Designation:{designation} Salary:{salary}  ");
        }
    }
}
