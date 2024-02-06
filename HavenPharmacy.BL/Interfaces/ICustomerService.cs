using HavenPharmacy.Models;

namespace HavenPharmacy.BL.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();

        Customer GetCustomerById(int customerId);

        void AddCustomer(Customer customer);

        void RemoveCustomer(int customerId);
    }
}
