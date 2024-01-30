namespace HandsOnClassTypes
{
    //static class create using static keyword
    //staic class define only static members
    //static classes are not instantiated (not able to create object)
    // static class are not inherited
    //static class are access by class name runtime time
    
    
    static class Convertor 
    {
        public static int a;
        public static double RTD(double rupess) 
        {
            return rupess / 78.5;
        }
        public static double DTR(double dollers) 
        {
            return dollers * 78.5;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:C}",Convertor.RTD(1000000));
            Console.WriteLine(Convertor.DTR(1000));
        }
    }
}
