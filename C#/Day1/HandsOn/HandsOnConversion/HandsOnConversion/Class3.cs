using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Class3
    {
        static void main() 
        {
            //convert one type to another type
            //using Convert class we can convert one type to another type
            double d = 12.34;
            int k = Convert.ToInt32(d);
            k = Convert.ToInt32("32323");
            object o = 23;
            k =Convert.ToInt32(o);
            double dd =Convert.ToDouble("3242");
            o = 343.878;
            dd=Convert.ToDouble(o);
            string s = "s";
            char ch = Convert.ToChar(s);
            double ddd = 3434.55;
            s=Convert.ToString(ddd);
        }
    }
}
