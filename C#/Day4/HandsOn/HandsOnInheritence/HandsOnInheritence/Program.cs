namespace HandsOnInheritence
{
    class A
    {
        public int a;
        public int b;
    }
    class B : A
    {
        public int c;
        public void F()
        {
            a = 10; b = 20; c = 30;
        }
        public void Display() 
        {
            Console.WriteLine($"A={a} B={b} C={c}");
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
           B obj = new B();
            obj.F();
            obj.Display();
            B obj1 = new B();
            obj1.a = 130;
            obj1.b = 250;
            obj1.c = 40;
            obj1.Display();
        }
    }
}
