using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritence
{
    class II 
    {
        protected int a;
        protected int b;
        public II(int a, int b ) 
        {
            this.a=a; this.b = b;
        }
    }

    class JJ : II 
    {
        public JJ() : base(2, 3) //base keyword use to call base class parameter constructor
        { }

        public JJ(int k,int l):base(k,l) 
        { }
        public void f() 
        {
            Console.WriteLine($"a={a} b={b}");
        }

    }
    internal class Demo3
    {

        public static void Main() 
        {
            JJ obj = new JJ();
            obj.f();
            JJ obj1 = new JJ(23,55);
            obj1.f();
        }
    }
}
