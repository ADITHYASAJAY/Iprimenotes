using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo3
    {
        public static void Main() 
        {
            //2-dimensional array
            //datatype [,] array_name = new datatype[row_size,col_size]
            int[,] _2darray = new int[3,2];//arrange array elements in 3 rows and 2 columns
            //1st row
            _2darray[0,0] = 88;
            _2darray[0, 1] = 11;
            //2nd row
            _2darray[1,0] = 22;
            _2darray[1,1] = 33;
            //3rd row
            _2darray[2, 0] = 65;
            _2darray[2,1] = 12;

            foreach (int i in _2darray) {
                Console.WriteLine(i);
            }

            Console.WriteLine("Display values in matrix format");

            for (int i=0;i<3;i++) 
            {
                for(int j = 0; j < 2; j++) 
                {
                    Console.Write(_2darray[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
