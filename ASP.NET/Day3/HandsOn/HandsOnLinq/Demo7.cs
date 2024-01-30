using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo7
    {
        static void Main() 
        {
            List<Student> students = new List<Student>() 
            {
                new Student (1,"Hari"),
                new Student (2,"Ravi"),
                new Student (3,"leo"),
                new Student (4,"Akash"),
            };

            //return first occurence
            Student s = students.First();
            s=students.Where(f=>f.Name.Length>4).First();
            Console.WriteLine(s.Name);

            //return last occurence
            s = students.Last();
            s= students.Where(f=>f.Name.Length<4).Last();
            Console.WriteLine(s.Name);

            s = students.Where(s => s.Name.Length > 3).FirstOrDefault();
            Console.WriteLine(s.Name);

            s = students.Where(s => s.Name.Length <5).LastOrDefault();
            Console.WriteLine(s.Name);

            s = students.Single(s => s.Id == 2);
            Console.WriteLine(s.Name);

            s= students.SingleOrDefault(s => s.Id == 3);
            if (s != null)
                Console.WriteLine(s.Name);
            else
                Console.WriteLine("Invalid Id");

            s = students.SingleOrDefault(s => s.Name == "Hari");
            Console.WriteLine(s.Name);

            List<Student> list = students.Where(s=>s.Name.Length>3).ToList();
            Student[] students1 = students.Where(s => s.Name.Length > 3).ToArray();
            Student s1 = students.Where(s => s.Name.Length > 3).ElementAt(0);
            s1 = students.Where(s => s.Name.Length > 3).ElementAt(1);

        }
    }
}
