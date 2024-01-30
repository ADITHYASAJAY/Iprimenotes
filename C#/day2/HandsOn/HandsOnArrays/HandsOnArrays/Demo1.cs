using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo1
    {
        static void Main() 
        {
            string[] students =new string[5] {
                "abiya",
                "arya",
                "adithya",
                "faris",
                "alfia"
            };
            Console.WriteLine("Enter the name ");
            string name = Console.ReadLine();
            bool flag =false;
           
            foreach (string s in students) 
            {
                if (s == name) 
                {
                    flag = true;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine($"{name} is Seleted for the the Test");
            }
            else 
            {
                Console.WriteLine($"{name} is Not Selected, hard luck");
            }
        }
    }
}
