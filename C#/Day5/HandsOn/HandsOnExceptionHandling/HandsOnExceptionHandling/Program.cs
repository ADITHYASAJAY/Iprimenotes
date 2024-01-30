namespace HandsOnExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 1 };
            try 
            {
                for (int i = 0; i < 4; i++)
                    Console.WriteLine(array[i]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range exception");
                Console.WriteLine(e.Message);

            }
        }
    }
}
