using HavenPharmacy.Models.Request;

namespace HavenPharmacy.BL.Interfaces
{
    public class AddProductToCustomerReuqest
    {
        public int CustomerId { get; set; }

        public GetProductByIdRequest GetProductByIdRequest { get; set; }
    }
}