using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo4
    {
        static void Main() 
        {
            string[,] logins = new string[5, 2] {
            {"hani","12345" },
            {"Abay","12345" },
            {"harini","12345" },
            {"arya","12345" },
            {"faris","12345" },
            };

            Console.WriteLine("Enter Username");
            string uName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pwd = Console.ReadLine();
            bool flag = false;
            for(int i = 0; i < 5; i++) 
            {
                if (logins[i,0]==uName && logins[i, 1] == pwd) 
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Valid Student Credentials");
            }
            else
                Console.WriteLine("Invalid Student Credentials ");
        }
    }
}
