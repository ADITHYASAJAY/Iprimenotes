namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name);
        }
    }
}
