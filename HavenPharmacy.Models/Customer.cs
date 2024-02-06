namespace HavenPharmacy.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        
        public string Name { get; set; }
        
        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public List<Product> PurchasedProducts { get; set; } = new List<Product>();

        public Customer(int customerId, string name, string address, string phoneNumber)
        {
            CustomerId = customerId;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public Customer()
        {
        }
    }

}
