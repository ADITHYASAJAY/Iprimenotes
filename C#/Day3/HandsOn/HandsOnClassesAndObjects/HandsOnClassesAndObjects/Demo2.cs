using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo2
    {
        public string  Greet(string name)
        {
            return "Hello" + name;

        }
        public double Square(double a) 
        {
            double r = a * a;
            return r;
        }

        public int Add(int a, int b = 10) 
        {
            return a + b;
        }
        public bool IsEven(int no) 
        {
            return no% 2==0 ? true : false;
        }

        static void Main(string[] args) 
        { 
            Demo2 demo = new Demo2();
            string result = demo.Greet("Virat");
            Console.WriteLine(result);
            Console.WriteLine(demo.Greet("Sachin"));
            Console.WriteLine(demo.Square(25));
            Console.WriteLine(demo.IsEven(23)?"Even":"Odd");
        }

    }
   
}
