using HavenPharmacy.BL.Interfaces;
using HavenPharmacy.DL.Interfaces;
using HavenPharmacy.Models;

namespace HavenPharmacy.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int productId)
        {
            return _productRepository.GetProductById(productId);
        }

        public void RemoveProduct(int productId)
        {
            _productRepository.RemoveProduct(productId);
        }
    }
}
