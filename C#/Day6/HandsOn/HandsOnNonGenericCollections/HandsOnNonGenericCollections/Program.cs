using System.Collections;

namespace HandsOnNonGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add("adi");
            obj.Add(5.8);
            obj.Add(4.99);
            obj.Add(5);
            obj.Add(true);
            obj.Add(false);
            Console.WriteLine(obj.Count);
            obj.Remove(1);
            Console.WriteLine(obj.Count);
            obj.Insert( 2, "hello");
            foreach(object k in obj)
            {
                Console.WriteLine(k);

            }
            Console.WriteLine("Size:" + obj.Count);

            foreach(var v in obj) 
            {
                Console.WriteLine(v);
            }


        }
    }
}
