using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections;

namespace Assignment_Collectios
{
    class Employee 
    {
        string name;
        string designation;
        public string Name {  get { return name; } set {  name = value; } }
        public string Designation {  get { return designation; } set {  designation = value; } }     
    }
    class EmployeeDesignationComparer : IComparer<Employee>
    {
        Dictionary<string, int> DesignationOrder = new Dictionary<string, int>
        {
            { "Program Managers", 1 },
            { "Project Manager", 2 },
            { "Team Lead", 3 },
            { "Senior Programmer", 4 },
            { "Junior Programmer", 5 },
       
        };

        public int Compare(Employee x, Employee y)
        {
            int xOrder = DesignationOrder[x.Designation];
            int yOrder = DesignationOrder[y.Designation];

            return xOrder.CompareTo(yOrder);
        }
    }

    internal class SortedEmployeeDetails
    {

        public static void Main() 
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Name="Hari", Designation="Project Manager" });
            list.Add(new Employee { Name = "Rojer", Designation = "Program Managers" });
            list.Add(new Employee { Name="Helen",Designation= "Team Lead" });
            list.Add(new Employee { Name = "Keller", Designation = "Program Managers" });
            list.Add(new Employee { Name = "Akash", Designation = "Project Manager" });  
            list.Add(new Employee { Name = "Aromal", Designation = "Team Lead" });
            list.Add(new Employee { Name = "Akshay", Designation = "Senior Programmer" });
            list.Add(new Employee { Name = "Midhun", Designation = "Junior Programmer" });
            list.Add(new Employee { Name = "Leo", Designation = "Team Lead" });
            list.Add(new Employee { Name = "Priya", Designation = "Program Managers" });
            list.Add(new Employee { Name = "Darshana", Designation = "Program Managers" });
            list.Add(new Employee { Name = "Ann", Designation = "Team Lead" });
            list.Add(new Employee { Name = "Mary", Designation = "Senior Programmer" });
            list.Add(new Employee { Name = "Jessica", Designation = "Program Managers" });
            list.Add(new Employee { Name = "Jane", Designation = "Junior Programmer" });

            list.Sort(new EmployeeDesignationComparer());

            
           
            foreach(var v in list) 
            {
                Console.WriteLine($"Name:{v.Name} Designation:{v.Designation}");
            }
        }
    }
}
