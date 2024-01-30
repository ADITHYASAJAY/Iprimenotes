using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo6
    {
        static void Main() 
        {
            string[] flowers = { "dahlia", "rose","jasmine","lily","lotus","daffodil"};
            IEnumerable<string> f = flowers.Where(flower => flower.StartsWith("d"));
            foreach (string flower in f) 
            {
                Console.WriteLine(flower);
            }

            //sort elements
            f= flowers.OrderBy(flower => flower);
            f= flowers.Where(flower => flower.StartsWith("d")).OrderByDescending(f=>f);

            Console.WriteLine();

            foreach (string flower in f)
            {
                Console.WriteLine(flower);
            }

            //group by length\
            Console.WriteLine();

            var result = flowers.GroupBy(flower => flower.Length).OrderBy(f=>f.Key);
            foreach (var v in result)
            {
                Console.WriteLine("Length:" + v.Key);
                foreach (var flower in v) 
                {
                    Console.WriteLine($"Flower: {flower}");
                }
            }


        }
    }
}
