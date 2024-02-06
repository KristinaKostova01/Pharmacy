using HavenPharmacy.Models;

namespace HavenPharmacy.DL.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
        void AddProduct(Product product);
        void UpdateProduct(Product updatedProduct);
        void RemoveProduct(int productId);
    }

}
