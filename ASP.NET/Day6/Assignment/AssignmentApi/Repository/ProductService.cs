using AssignmentApi.Model;

namespace AssignmentApi.Repository
{
    public class ProductService : IProductService
    {
        List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            try 
            {
                products.Add(product);      
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteProduct(string productName)
        {
            try 
            {
                var item = products.Where(p=>p.ProductName == productName).FirstOrDefault();
                if(item != null) 
                {
                    products.Remove(item);
                } 

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Product> GetProductByCategory(string category)
        {
            try 
            {
                var productBycategory = products.Where(p => p.Category.Equals(category)).Select(p=>p);
                return productBycategory.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Product GetProductByNameOrCategory(string productNameorCategory)
        {
            try 
            {
                Product productByNameorCategory = new Product();
                foreach (var item in products)
                {
                    if (item.ProductName.Equals(productNameorCategory) || item.Category.Equals(productNameorCategory))
                    {
                        productByNameorCategory = item;
                        break;
                    }
                }
                return productByNameorCategory;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try 
            {
                foreach (var item in products)
                {
                    if (item.ProductName.Equals(product.ProductName))
                    {
                        
                        item.Price = product.Price; 
                        item.Category = product.Category;
                        item.Category=product.Category;
                        item.Stock = product.Stock; 
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
