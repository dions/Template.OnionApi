using Example.Data.Interfaces;
using Example.Domain.Models;
using Template.Service.Interfaces;

namespace Template.Service.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) 
        {
            _customerRepository = customerRepository;
        }

        public Customer Get(int id)
        {
            return _customerRepository.Get(id);
        }
    }
}
