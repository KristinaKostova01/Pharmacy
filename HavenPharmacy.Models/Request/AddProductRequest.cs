namespace HavenPharmacy.Models.Request
{
    public class AddProductRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
