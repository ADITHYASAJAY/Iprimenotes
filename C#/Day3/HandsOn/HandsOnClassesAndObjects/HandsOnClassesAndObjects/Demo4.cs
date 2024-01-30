using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo4
    {
        static void add(int a, int b) 
        {
            int c = 0;
            c=a+ b;
            Console.WriteLine(c);
        }

        static void add(int a, int b, int c) 
        {
            int x = 0;
            x= a+ b+c;
            Console.WriteLine(x);
        }
        static void add(double a, double b) 
        {
            double c = 0;   
            c= a+ b;
            Console.WriteLine(c);
        }

        static void Main() 
        {
            add(1, 2);
            add(3, 4, 5);
            add(4.2, 5.4);
        }

    }
}
