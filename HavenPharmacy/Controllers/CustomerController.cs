using HavenPharmacy.BL.Interfaces;
using HavenPharmacy.Models;
using Microsoft.AspNetCore.Mvc;

namespace HavenPharmacy.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            var customers = _customerService.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customer = _customerService.GetCustomerById(id);

            if (customer == null)
            {
                return NotFound(); // Return 404 Not Found if customer is not found
            }

            return Ok(customer);
        }

        [HttpPost]
        public ActionResult<Customer> AddCustomer([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest(); // Return 400 Bad Request if the provided customer is null
            }

            _customerService.AddCustomer(customer);

            // Return the added customer along with a 201 Created status
            return CreatedAtAction(nameof(GetCustomerById), new { id = customer.CustomerId }, customer);
        }

        [HttpDelete("{id}")]
        public ActionResult RemoveCustomer(int id)
        {
            var existingCustomer = _customerService.GetCustomerById(id);

            if (existingCustomer == null)
            {
                return NotFound(); // Return 404 Not Found if customer is not found
            }

            _customerService.RemoveCustomer(id);

            return NoContent(); // Return 204 No Content after successful removal
        }
    }
}
