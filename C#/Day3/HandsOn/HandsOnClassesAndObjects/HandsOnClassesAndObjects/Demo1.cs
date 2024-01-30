using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo1
    {
        private int a;

        public void Seta()
        {
            a = 10;
        }
        public void Message()
        {
            Console.WriteLine("Hello World");
        }

        public void Greet(string name)
        {
            Console.WriteLine("Hello" + name);

        }
        public void Add(int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine("Addition: " + c);
        }
    }
    class Test_Demo1
    {
        static void Main()
        {
            Demo1 demo1 = new Demo1();
            demo1.Message();
            demo1.Seta();
            demo1.Message();
            demo1.Greet("Sachin");
            demo1.Greet("Virat");
            demo1.Add(45,56);
        }
    }
}
