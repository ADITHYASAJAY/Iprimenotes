namespace HandsOnGenericCollections
{
    class Sample<T> 
    {
        public T a;
        public T b;
        public void Details(T i , T j) 
        {
            a = i;
            b=j;
            Console.WriteLine($"a={a} and b={b}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Sample<int> sample = new Sample<int>();          
            sample.a = 10;
            sample.b = 20;
            sample.Details(1,2);
            Sample<char> sample1 = new Sample<char>();
            sample1.a = 'a';
            sample.b = 'b';
            Sample<string> sample2 = new Sample<string>();
            sample2.Details("rahul", "dravid");
        }
    }
}
