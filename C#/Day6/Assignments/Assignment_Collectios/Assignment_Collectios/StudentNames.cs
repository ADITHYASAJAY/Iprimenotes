using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Collectios
{
    internal class StudentNames
    {
        static void Main() 
        {
            ArrayList studentsName = new ArrayList();
            Console.WriteLine("Enter the number of students");
            int count=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Students name");
            for(int i = 0; i < count; i++) 
            {
                string s=Console.ReadLine();
                studentsName.Add(s);
            }
            studentsName.Reverse();
            Console.WriteLine("Students name in descending order");
            foreach(object s in studentsName) 
            {
                Console.WriteLine(s);
            }
        
        }
    }
}
