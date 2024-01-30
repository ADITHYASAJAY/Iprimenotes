namespace AssignmentApi.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public DateOnly OrderDate { get; set; }
        public int Quantity { get; set; }
        public double Amount {  get; set; }
    }
}
