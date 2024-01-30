using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Collectios
{
    class Student 
    {
        int id;
        string name;
        short age;
        byte std;
        char section;
        public int Id {  get { return id; } set {  id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public short Age { get { return age; } set { age = value; } }
        public byte Std { get { return std; } set { std = value; } }
        public char Section { get { return section; } set { section = value; } }

    }
    internal class StudentDetails
    {
        public static void Main() 
        {
            Student student = new Student();
            ArrayList studentDetails = new ArrayList();
            studentDetails.Add(student.Id = 1);
            studentDetails.Add(student.Name = "Aromal");
            studentDetails.Add(student.Age =10);
            studentDetails.Add(student.Std =5);
            studentDetails.Add(student.Section = 'A');
            
            foreach(object obj in studentDetails) 
            {
                Console.WriteLine(obj.ToString());  
            }

            Student student2 = new Student();
            student2.Id = 2;
            student2.Name = "Akash";
            student2.Age = 10;
            student2.Std = 5;
            student2.Section = 'C';
            ArrayList arrayList = new ArrayList();
            arrayList.Add(student2);

            foreach(object obj in arrayList) 
            {
                Student s = obj as Student;
                Console.WriteLine($"Id:{s.Id} Name:{s.Name} Age:{s.Age} Std:{s.Std} Section:{s.Section}");
            }

        }
    }
}
