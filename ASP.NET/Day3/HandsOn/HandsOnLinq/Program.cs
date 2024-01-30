namespace HandsOnLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 2, 34, 4, 545, 55, 4, 33, 35, 338, 23, 54, 123, 13, 32, 13, 1, 2334, 44 };

            var result = from k in n
                         where k > 50
                         select k;
            

            result = from k in n
                     select k + 1;

            result = from k in n
                     where k*k>1000
                     select k *k;

            result = from k in n
                     let i = k+k
                     where i > 100
                     select k + k;

            result = from k in n
                     where k>100
                     orderby k
                     select k;

            result = from k in n
                     where k > 200
                     orderby k descending
                     select k;
            
            foreach (var i in result) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
