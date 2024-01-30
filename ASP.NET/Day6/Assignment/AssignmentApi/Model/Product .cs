namespace AssignmentApi.Model
{
    public class Product
    {
        private static int id = 1;
        public Product() 
        {
            ProductId = id;
            id++;
        }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double Price {  get; set; }
        public int Stock { get; set; }
    }
}
