using HavenPharmacy.DL.Interfaces;
using HavenPharmacy.DL.MemoryDB;
using HavenPharmacy.Models;

namespace HavenPharmacy.DL.Respositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers;

        public CustomerRepository()
        {
            _customers = InMemoryDb.CustomerData;
        }

        public List<Customer> GetAllCustomers()
        {
            return _customers.ToList();
        }

        public Customer GetCustomerById(int customerId)
        {
            return _customers.FirstOrDefault(c => c.CustomerId == customerId);
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void UpdateCustomer(Customer updatedCustomer)
        {
            var existingCustomer = _customers.FirstOrDefault(c => c.CustomerId == updatedCustomer.CustomerId);
            if (existingCustomer != null)
            {
                existingCustomer.Name = updatedCustomer.Name;
                existingCustomer.Address = updatedCustomer.Address;
                existingCustomer.PhoneNumber = updatedCustomer.PhoneNumber;
            }
        }

        public void RemoveCustomer(int customerId)
        {
            var customerToRemove = _customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customerToRemove != null)
            {
                _customers.Remove(customerToRemove);
            }
        }
    }
}
