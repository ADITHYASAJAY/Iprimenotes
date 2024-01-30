using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Demo3
    {
        //public int Sum(int[] a) 
        //{ 
        //    int sum = 0;
        //    foreach (int i in a) 
        //    { 
        //        sum+= i;
        //    }
        //    return sum;
        //}
        public int Sum(params int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum;
        }
        public string[] Flowers() 
        {
            string[] flowers = { "rose", "lilly", "Jasmine" };
            return flowers;
        }
        static void Main() 
        {
            Demo3 demo = new Demo3();
            int r = demo.Sum(new int[] { 23, 4, 23, 34, 44 });
            Console.WriteLine(r);
            int[] n = { 5656,675,77,898};
            r=demo.Sum(n);
            Console.WriteLine(r);
            string[] result = demo.Flowers();
            foreach (string s in result)
                Console.WriteLine(s);

            r= demo.Sum(1,3,44,449);
            Console.WriteLine(r);
            r= demo.Sum(334,5,56,7);
            Console.WriteLine(r);
        }
    }
}
