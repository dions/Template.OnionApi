using Example.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example.WebApi1.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpGet(Name = "GetAllCustomers")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return new List<Customer> { 
                new(1) { Name = "Bob", IsActive = true },
                new(1) { Name = "Jane", IsActive = true }
            };
        }

        [HttpGet("{id}", Name = "GetCustomerById")]
        public Customer GetCustomerById(int id)
        {
            return new Customer(id);
        }
    }
}
