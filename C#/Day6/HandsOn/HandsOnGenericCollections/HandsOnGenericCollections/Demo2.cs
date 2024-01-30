using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class KeyValue<K, V> 
    {
        public K Id { get; set; }
        public V Name { get; set; }
        
    }
    internal class Demo2
    {
        static void Main() 
        {
            KeyValue<int, string> ob = new KeyValue<int, string>();
            ob.Id = 1;
            ob.Name = "test";
            KeyValue<double, char> ob1 = new KeyValue<double, char>();
            ob1.Id = 2.99;
            ob1.Name = 'a';
            Console.WriteLine(ob1.Id);
            Console.WriteLine(ob1.Name);
            Console.WriteLine(ob.Id);
            Console.WriteLine(ob.Name);

        }
    }
}
