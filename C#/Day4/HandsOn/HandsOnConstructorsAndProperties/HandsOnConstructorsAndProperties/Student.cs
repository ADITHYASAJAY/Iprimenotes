using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties_1
{
    internal class Student
    {
        private int id;
        private string name;
        private int total;
        private int[] marks = new int[] { 88,88,98,43,78,81};
        public int ID 
        {
            get { return id; }
            set { id = value; }
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public int Marks 
        {
            get
            {
                total = 0;
                foreach (int k in marks)
                { total += k; }
                return total;
            }
          
        }
        public string Grade 
        {
            get 
            {
                if (total >= 700)
                {
                    return "A++";
                }
                else if (total >= 600)
                {
                    return "A";
                }
                else { return "B"; }

            }
        }
    }

    class Test_Student 
    {
        static void Main() 
        {
            Student obj = new Student();
            obj.ID = 123;
                obj.NAME = "rajan";
            Console.WriteLine($"Id :{obj.ID} Name: {obj.NAME} Marks: {obj.Marks} Grade: {obj.Grade} ");
        }
    }
}
