using HavenPharmacy.Models;

namespace HavenPharmacy.DL.MemoryDB
{
    public static class InMemoryDb
    {
        public static List<Product> ProductData = new List<Product>()
        {
            new Product()
            {
                ProductId = 1,
                Name = "Product 1",
                Price = 10.99m,
                QuantityInStock = 100
            },
            new Product()
            {
                ProductId = 2,
                Name = "Product 2",
                Price = 25.50m,
                QuantityInStock = 50
            },
            new Product()
            {
                ProductId = 3,
                Name = "Product 3",
                Price = 5.99m,
                QuantityInStock = 75
            },
        };

        public static List<Customer> CustomerData = new List<Customer>()
        {
            new Customer()
            {
                CustomerId = 1,
                Name = "Customer 1",
                Address = "123 Main St",
                PhoneNumber = "555-1234"
            },
            new Customer()
            {
                CustomerId = 2,
                Name = "Customer 2",
                Address = "456 Elm St",
                PhoneNumber = "555-5678"
            },
            new Customer()
            {
                CustomerId = 3,
                Name = "Customer 3",
                Address = "789 Oak St",
                PhoneNumber = "555-9876"
            },
        };
    }
}
