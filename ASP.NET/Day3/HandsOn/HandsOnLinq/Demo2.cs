using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo2
    {
        static void Main() 
        {
            List<Flower> flowers = new List<Flower>();
            flowers.Add(new Flower("lilly", 5));
            flowers.Add(new Flower("rose", 25));
            flowers.Add(new Flower("jasmine", 6));
            flowers.Add(new Flower("dahlia", 6));
            flowers.Add(new Flower("lotus", 25));
            flowers.Add(new Flower("daffodil", 6));
            flowers.Add(new Flower("hibiscus", 5));
            flowers.Add(new Flower("sunflower", 15));


            var result = from f in flowers
                         where f.Name == "lilly"
                         select f;
            //prints flower with name lilly
            foreach (var f in result) 
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petal}");
            }

            Console.WriteLine();

            result = from f in flowers
                     where f.Name.StartsWith("l")
                     select f;
            //prints  flower name starts with l
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petal}");
            }

            Console.WriteLine();

            result = from f in flowers
                     where f.Name.EndsWith("e")
                     select f;
            //prints flower name ends with e
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petal}");
            }

            Console.WriteLine();

            result = from f in flowers
                     where f.Petal> 10
                     select f;
            //prints flowers with petal>10
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petal}");
            }

            Console.WriteLine();

            result = from f in flowers
                    orderby f.Name
                     select f;
            //prints flowers in asceding order with respect to flower name
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petal}");
            }


            Console.WriteLine();

            result = from f in flowers
                     where f.Name.StartsWith("d") && f.Petal<10 
                     select f;
            //prints  flower name starting with d and petal should be less than 10
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petal}");
            }

            Console.WriteLine();

            result = from f in flowers
                     orderby f.Petal descending
                     select f;
            //prints  flower in descending order with respect to petal
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petal}");
            }


            //group by

            var result2 = from Flower flower in flowers
                     orderby flower.Petal
                     group flower by flower.Petal;

            foreach (var f in result2) 
            {
                Console.WriteLine("Flowers with " + f.Key + "petals");
                foreach(var n in f)
                {
                    Console.WriteLine(" " + n.Name);
                }
            }


        }
    }
}
