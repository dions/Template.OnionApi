using Example.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example.WebApi1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet(Name = "GetAllCustomers")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return new List<Customer>();
        }

        [HttpGet("{id}", Name = "GetCustomerById")]
        public Customer GetCustomerById(int id)
        {
            return new Customer(id);
        }
    }
}
