using HavenPharmacy.Models.Request;
using HavenPharmacy.Models.Response;

namespace HavenPharmacy.BL.Interfaces
{
    public interface IPharmacyService
    {
        AddProductResponse AddProduct(AddProductRequest request);

        GetAllProductsResponse GetAllProducts();

        void AddProductToCustomer(AddProductToCustomerReuqest request);
    }
}
