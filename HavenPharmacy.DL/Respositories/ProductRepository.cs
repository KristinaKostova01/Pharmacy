using HavenPharmacy.DL.Interfaces;
using HavenPharmacy.DL.MemoryDB;
using HavenPharmacy.Models;

namespace HavenPharmacy.DL.Respositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = InMemoryDb.ProductData;
        }

        public List<Product> GetAllProducts()
        {
            return _products.ToList();
        }

        public Product GetProductById(int productId)
        {
            return _products.FirstOrDefault(p => p.ProductId == productId);
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void UpdateProduct(Product updatedProduct)
        {
            var existingProduct = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
            
            if (existingProduct != null)
            {
                existingProduct.Name = updatedProduct.Name;
                existingProduct.Price = updatedProduct.Price;
                existingProduct.QuantityInStock = updatedProduct.QuantityInStock;
            }
        }

        public void RemoveProduct(int productId)
        {
            var productToRemove = _products.FirstOrDefault(p => p.ProductId == productId);
            if (productToRemove != null)
            {
                _products.Remove(productToRemove);
            }
        }
    }
}
