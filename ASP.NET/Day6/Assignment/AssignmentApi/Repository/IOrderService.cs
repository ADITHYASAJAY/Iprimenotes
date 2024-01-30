using AssignmentApi.Model;

namespace AssignmentApi.Repository
{
    public interface IOrderService
    {
        void PlaceOrder(string productName, int quantity);
        List<Order> ViewOder();
        void DeleteProductFromOrder(Product product);
    }
}
