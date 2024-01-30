using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritence
{
    class X 
    {
        private int a;
        public int b;
        protected int c;
        internal int d;
    }
    class Y:X 
    {
       
        public void M() 
        {
            //a is private so wecan't access
            b = 12; c = 20;
        }
    }
    internal class Demo1
    {
        static void Main() 
        {
            Y obj = new Y();
            Console.WriteLine($"B:{obj.b} ");
        }
    }
}
