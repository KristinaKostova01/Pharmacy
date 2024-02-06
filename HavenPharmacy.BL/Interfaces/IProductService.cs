using HavenPharmacy.Models;

namespace HavenPharmacy.BL.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

        Product GetProductById(int productId);

        void AddProduct(Product product);

        void RemoveProduct(int productId);
    }
}
