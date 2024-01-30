using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo1
    {
        static void Main() 
        {
            List<int> list = new List<int>();
            list.Add(11);
            list.Add(21);
            list.Add(31);
            list.Add(24);
            list.Add(56);
            list.Add(68);
            int k = list[4];
            list.Remove(4);
            list.Sort();
            foreach(var i in list) 
            {
                Console.WriteLine(i);
            }
            list.Reverse();
            foreach(var i in list)
            { Console.WriteLine(i); }   
        }
    }
}
