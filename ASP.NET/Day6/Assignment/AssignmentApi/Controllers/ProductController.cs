using AssignmentApi.Model;
using AssignmentApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService productService;
        public ProductController(IProductService productService) 
        {
            this.productService = productService;
        }

        [HttpPost,Route("Add Product")]
        public IActionResult AddProduct(Product product)
        {
            try 
            {
                productService.AddProduct(product);
                return StatusCode(200, product);
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpPost,Route("UpdateProduct")]
        public IActionResult UpdateProduct(Product product) 
        {
            try 
            {   
                productService.UpdateProduct(product);
                return StatusCode(200, $"{product.ProductName} updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpDelete, Route("DeleteProduct")]
        public IActionResult DeleteProduct(string productName) 
        {
            try 
            {
                productService.DeleteProduct(productName);
                
                return StatusCode(200, $"{productName} Deleted Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet,Route("GetProductByName/{productNameorcategory}")]
        public IActionResult  GetProductByNameOrCategory(string productNameorcategory) 
        {
            try 
            {
                var product = productService.GetProductByNameOrCategory(productNameorcategory);
                if (product.ProductName == null) 
                {
                    return StatusCode(200, "no products with this name");
                }
                else 
                {
                    return StatusCode(200, product);
                }
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpGet, Route("GetProductByCategory/{category}")]
        public IActionResult GetProductByCategory(string category)
        {
            try 
            {
                var product = productService.GetProductByCategory(category);
                if (product==null)
                {
                    return StatusCode(200, "No product in this category");
                }
                else 
                {
                    return StatusCode(200, product);
                }
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        public  Product GetProducts(string name) 
        {
            var  product = productService.GetProductByNameOrCategory(name);
            return product;
        }
    }
}
