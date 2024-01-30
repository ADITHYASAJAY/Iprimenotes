using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    class A //base class
    {
        public void M() { }
    }
    sealed class B:A 
    {
        public void M1() { }
    }
    internal class Demo1
    {
        public static void Main() 
        {
            B obj = new B();
            obj.M();
            obj.M1();                                
        }
       
    }
}
