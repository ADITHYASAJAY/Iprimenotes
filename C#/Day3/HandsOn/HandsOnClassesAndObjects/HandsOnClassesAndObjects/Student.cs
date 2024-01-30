using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Student
    { 
        public string name;
        public int age;
        public int id;
        public char gender;

        public void Display() 
        {
            Console.WriteLine($"Id:{id} ,Name:{name} , Age:{age} ,Gender:{gender}");
        }

    }
}
