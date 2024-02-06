using HavenPharmacy.BL.Interfaces;
using HavenPharmacy.DL.Interfaces;
using HavenPharmacy.Models;

namespace HavenPharmacy.BL.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public Customer GetCustomerById(int customerId)
        {
            return _customerRepository.GetCustomerById(customerId);
        }

        public void RemoveCustomer(int customerId)
        {
            _customerRepository.RemoveCustomer(customerId);
        }
    }
}
