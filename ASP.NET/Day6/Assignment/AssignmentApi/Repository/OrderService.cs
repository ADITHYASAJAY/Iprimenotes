using AssignmentApi.Model;

namespace AssignmentApi.Repository
{
    public class OrderService : IOrderService
    {
        List<Order> orders=new List<Order>();
        public void DeleteProductFromOrder(Product product)
        {
            throw new NotImplementedException();
        }

     

        public void PlaceOrder(string productName, int quantity)
        {
            try
            {
                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Order> ViewOder()
        {
            try 
            {
                return orders;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
