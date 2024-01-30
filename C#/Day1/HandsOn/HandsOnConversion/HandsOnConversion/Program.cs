namespace HandsOnTypeConversion
{
    internal class Program
    {
        static void main(string[] args)
        {
            //conversion in between value types
            byte b = 34;
            int k = b;//implicit
            double d = b;
            short s = b;

            //explicit
            int m = 345;
            short ss = (short)m;
            byte bb = (byte)m;
            long ll = 23344;
            m = (int)ll;
            double dd = 34.88;
            m = (int)dd;
            ll = (long)dd;
            Console.WriteLine(m);

            decimal dc = 34.5645m;
            m = (int)dc;
            bb = (byte)dc;
            ss = (short)dc;
            ll = (long)dc;
            dd = (double)dc;

            //Convert values from reference type to value type
            string sen = "233";
            m=int.Parse(sen);
            bb=byte.Parse(sen);
            ss=short.Parse(sen);
            d=double.Parse(sen);
            float f=float.Parse(sen);
            dc=decimal.Parse(sen);

            //Convert values from value types to string type
            int k1 = 34;
            string s1=k1.ToString();
           s1=dd.ToString();

            //object is  a reference datatype which access any type of data
            object o1 = k;
            object o2 = bb;
            object o3= ss;
            //converting value type to object(boxing)
            int n = (int)o1;
            bb=(byte)o2;
            ss=(short)o3;
            Console.WriteLine(n);
            Console.WriteLine(ss);



        }
    }
}
