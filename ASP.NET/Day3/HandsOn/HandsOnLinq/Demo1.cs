using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo1
    {
        static void Main() 
        {
            string[] flowers = { "dahlia","lilly", "rose","lotus"};
            string[] fruits = { "banana","apple","orange","grape","apricot"};

            var result = from flower in flowers
                         where flower.Length>5
                         select flower.ToUpper();

            foreach ( var f in result )
                Console.WriteLine( f );

            Console.WriteLine();
            var result1 =from fruit in fruits
                         orderby fruit
                         select fruit;

            foreach(var f in result1)
                Console.WriteLine( f );
        }
    }
}
