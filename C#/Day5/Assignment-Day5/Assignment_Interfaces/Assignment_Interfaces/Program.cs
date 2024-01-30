using System.Security.Cryptography;
using System.Xml.Linq;

namespace Assignment_Interfaces
{
    public interface GovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaveDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);

    }
    class TCS : GovtRules
    {
        int empid;
        string name;
        string dept;
        string desg;
        double basicSalary;

        public int EMPID { get { return empid; } }
        public string Name { get { return name; } } 
        public string Department { get { return dept; } }

        public string Designation { get { return desg; } }

        public double BasicSalary { get { return basicSalary; } }
        public TCS(int empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;

        }

        public double EmployeePF(double basicSalary)
        {
            return (basicSalary * 0.24);
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
                return 3 * basicSalary;
            else if (serviceCompleted > 10)
                return 2 * basicSalary;
            else
                return 0;
        }

        public string LeaveDetails()
        {
            return "1 day of Casual Leave per month\n12 days of Sick Leave per year\n10 days of Previlage Leave per year";
           
        }
    }

    class Accenture : GovtRules
    {
        int empid;
        string name;
        string dept;
        string desg;
        double basicSalary;
        public int EMPID { get { return empid; } }
        public string Name { get { return name; } }
        public string Department { get { return dept; } }

        public string Designation { get { return desg; } }

        public double BasicSalary { get { return basicSalary; } }
        public Accenture(int empid,string name, string dept, string desg, double basicSalary) 
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
           
        }
        public double EmployeePF(double basicSalary)
        {
            return (basicSalary * 0.24);
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0;
        }

        public string LeaveDetails()
        {
            return "2 day of Casual Leave per month \n5 days of Sick Leave per year\n5 days of Previlage Leave per year";
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TCS tcs = new TCS(112, "Adithya S Ajay", "Testing", "Developer", 90000);
            Console.WriteLine("Employee Id:"+tcs.EMPID);
            Console.WriteLine("Employee Name:"+tcs.Name);
            Console.WriteLine("Employee Department:"+tcs.Department);
            Console.WriteLine("Employee Designation:" + tcs.Designation);
            Console.WriteLine("Employee Basic Salary:"+tcs.BasicSalary);
            Console.WriteLine("Employee PF:"+tcs.EmployeePF(90000));
            Console.WriteLine("Leave Details of Tcs: "+tcs.LeaveDetails());
            Console.WriteLine("GratutityAmount:" + tcs.gratuityAmount(20,90000));

            Accenture accenture = new Accenture(112, "Akash", "Development", "Developer", 180000);
            Console.WriteLine("Employee Id:" + accenture.EMPID);
            Console.WriteLine("Employee Name:" + accenture.Name);
            Console.WriteLine("Employee Department:" + accenture.Department);
            Console.WriteLine("Employee Designation:" + accenture.Designation);
            Console.WriteLine("Employee Basic Salary:" + accenture.BasicSalary);
            Console.WriteLine("Employee PF:" + accenture.EmployeePF(180000));
            Console.WriteLine("Leave Details of Tcs: " + accenture.LeaveDetails());
            Console.WriteLine("GratutityAmount:" + accenture.gratuityAmount(10, 180000));


        }
    }
}
