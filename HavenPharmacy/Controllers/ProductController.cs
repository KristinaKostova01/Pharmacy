using HavenPharmacy.BL.Interfaces;
using HavenPharmacy.Models;
using Microsoft.AspNetCore.Mvc;

namespace HavenPharmacy.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound(); // Return 404 Not Found if product is not found
            }

            return Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> AddProduct([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest(); // Return 400 Bad Request if the provided product is null
            }

            _productService.AddProduct(product);

            // Return the added product along with a 201 Created status
            return CreatedAtAction(nameof(GetProductById), new { id = product.ProductId }, product);
        }

        [HttpDelete("{id}")]
        public ActionResult RemoveProduct(int id)
        {
            var existingProduct = _productService.GetProductById(id);

            if (existingProduct == null)
            {
                return NotFound(); // Return 404 Not Found if product is not found
            }

            _productService.RemoveProduct(id);

            return NoContent(); // Return 204 No Content after successful removal
        }
    }
}
