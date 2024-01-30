using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnNonGenericCollections
{
    internal class Demo1
    {
        static void Main() 
        {
            Hashtable obj = new Hashtable();
            obj.Add(34434,"rohan");
            obj.Add(43434,"hari");
            obj.Add(76786, "aromal");
            obj.Add(2222,"leo");
            obj.Remove(2222);
            foreach (int k in obj.Keys) 
            {
                Console.WriteLine($"ID:{k} Name:{obj[k]}");
            }
        }
    }
}
