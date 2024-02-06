using HavenPharmacy.BL.Interfaces;
using HavenPharmacy.Models;
using HavenPharmacy.Models.Request;
using HavenPharmacy.Models.Response;
using System.Xml.Linq;

namespace HavenPharmacy.BL.Services
{
    public class PharmacyService : IPharmacyService
    {
        private readonly IProductService _productService;

        private readonly ICustomerService _customerService;

        public PharmacyService(IProductService productService, ICustomerService customerService)
        {
            _productService = productService;
            _customerService = customerService;
        }

        public AddProductResponse AddProduct(AddProductRequest request)
        {
            var newProduct = new Product()
            {
                Name = request.Name,
                Price = request.Price,
                QuantityInStock = request.QuantityInStock,
            };
            
             _productService.AddProduct(newProduct);
            return new AddProductResponse()
            {
                Name = request.Name,
                Price = request.Price,
                QuantityInStock = request.QuantityInStock,
            };
        }

        public void AddProductToCustomer(AddProductToCustomerReuqest request)
        {
            var customer = _customerService.GetCustomerById(request.CustomerId);

            var productId = request.GetProductByIdRequest.ProductId;
            var foundProduct = _productService.GetProductById(productId);

            if (customer == null || foundProduct == null)
            {
                return;
            }

            customer.PurchasedProducts.Add(foundProduct);
        }

        public GetAllProductsResponse GetAllProducts()
        {            
            var productsResponse = _productService.GetAllProducts();

            return new GetAllProductsResponse()
            {
                Products = productsResponse
            };
        }
    }
}
