using System.Runtime.InteropServices;

namespace HandsOnConstructorsAndProperties
{
    class Student 
    {
        public string firstName;
        public string lastName;
        public string school;
        public static string city;


        //public Student()
        //{
        //    school = "DPS";
        //}
        public Student(string fname, string lname,string s) 
        {
            firstName = fname;
            lastName = lname;
            school = s; 
        }
        public Student( string fname,string lname) 
        {
            firstName= fname;
            lastName= lname;
        }
        static Student()
        {
            city = " Kochi";
        }

        public void Display() 
        {
            Console.WriteLine($"Name: {firstName} {lastName} School: {school}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Student student2 = new Student("akash","s","SSN");
            student2.Display();

            Student student1 = new Student("aromal","ajith");
            student1.school = "mgm";
            student1.Display();

        }
    }
}
