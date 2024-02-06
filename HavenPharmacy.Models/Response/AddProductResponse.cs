namespace HavenPharmacy.Models.Response
{
    public class AddProductResponse
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
