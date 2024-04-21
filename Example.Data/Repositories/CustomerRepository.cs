using Example.Data.Base;
using Example.Data.Interfaces;
using Example.Domain.Models;

namespace Example.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {

    }
}
