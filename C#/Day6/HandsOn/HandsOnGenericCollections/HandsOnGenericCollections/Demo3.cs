using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class Student 
    {
        public Student(int id, string name) 
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; } 
        public string Name { get; set; }
    }
    internal class Demo3
    {
        static void Main() 
        {
            List<string> list = new List<string>() { "Rose","Lilly","Jasmine"};
            List<bool> list2 = new List<bool>() { true, false ,false,true};
            List<Student> students = new List<Student>()
            {
                new Student(3233,"Manoj"),
                new Student(3233,"Ann"),
                new Student(3233,"Hanni"),
                new Student(3233,"Nedhi"),
                new Student(3233,"Priya"),
            };

            students.Add(new Student(59899, "Varun"));
            Student s = students[4];
            foreach(var k in students)
                Console.WriteLine($"ID:{k.Id} Name:{k.Name}");
            
        }

    }
}
