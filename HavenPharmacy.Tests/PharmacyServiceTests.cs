using HavenPharmacy.BL.Interfaces;
using HavenPharmacy.BL.Services;
using HavenPharmacy.Models.Request;
using HavenPharmacy.Models;
using Moq;

namespace HavenPharmacy.Tests
{
    public class PharmacyServiceTests
    {
        private static readonly List<Product> ProductData = new List<Product>
        {
            new Product { ProductId = 1, Name = "Product 1", Price = 10.0M, QuantityInStock = 50 },
            new Product { ProductId = 2, Name = "Product 2", Price = 20.0M, QuantityInStock = 30 },
            new Product { ProductId = 3, Name = "Product 3", Price = 15.0M, QuantityInStock = 40 }
        };


        [Fact]
        public void AddProduct_ShouldReturnCorrectResponse()
        {
            var productServiceMock = new Mock<IProductService>();
            productServiceMock.Setup(x => x.AddProduct(It.IsAny<Product>()));

            var pharmacyService = new PharmacyService(productServiceMock.Object, null);

            var addProductRequest = new AddProductRequest
            {
                Name = "New Product",
                Price = 25.0M,
                QuantityInStock = 10
            };

            var result = pharmacyService.AddProduct(addProductRequest);

            Assert.NotNull(result);
            Assert.Equal(addProductRequest.Name, result.Name);
            Assert.Equal(addProductRequest.Price, result.Price);
            Assert.Equal(addProductRequest.QuantityInStock, result.QuantityInStock);
        }

        [Fact]
        public void AddProductToCustomer_ShouldAddProductToCustomer()
        {
            var customerId = 1;
            var productId = 2;

            var customerServiceMock = new Mock<ICustomerService>();
            customerServiceMock.Setup(x => x.GetCustomerById(customerId)).Returns(new Customer { CustomerId = customerId });

            var productServiceMock = new Mock<IProductService>();
            productServiceMock.Setup(x => x.GetProductById(productId)).Returns(ProductData.FirstOrDefault(p => p.ProductId == productId));

            var pharmacyService = new PharmacyService(productServiceMock.Object, customerServiceMock.Object);

            var addProductToCustomerRequest = new AddProductToCustomerReuqest
            {
                CustomerId = customerId,
                GetProductByIdRequest = new GetProductByIdRequest { ProductId = productId }
            };

            pharmacyService.AddProductToCustomer(addProductToCustomerRequest);
                        
            customerServiceMock.Verify(x => x.GetCustomerById(customerId), Times.Once);
            productServiceMock.Verify(x => x.GetProductById(productId), Times.Once);
        }

        [Fact]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            var productServiceMock = new Mock<IProductService>();
            productServiceMock.Setup(x => x.GetAllProducts()).Returns(ProductData);

            var pharmacyService = new PharmacyService(productServiceMock.Object, null);

            var result = pharmacyService.GetAllProducts();

            Assert.NotNull(result);
            Assert.Equal(ProductData.Count, result.Products.Count);
        }
    }
}