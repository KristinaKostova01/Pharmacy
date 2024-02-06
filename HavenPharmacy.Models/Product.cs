namespace HavenPharmacy.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        public Product(int productId, string name, decimal price, int quantityInStock)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public Product()
        {
        }
    }

}
