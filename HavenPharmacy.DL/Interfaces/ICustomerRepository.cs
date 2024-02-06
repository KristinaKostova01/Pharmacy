using HavenPharmacy.Models;

namespace HavenPharmacy.DL.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int customerId);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer updatedCustomer);
        void RemoveCustomer(int customerId);
    }

}
