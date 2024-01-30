using AssignmentApi.Model;

namespace AssignmentApi.Repository
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(string productName);
        Product GetProductByNameOrCategory(string productNameOrCategory);
        List<Product> GetProductByCategory(string category);
    }
}
