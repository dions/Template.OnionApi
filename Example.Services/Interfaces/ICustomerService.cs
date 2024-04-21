using Example.Domain.Models;

namespace Template.Service.Interfaces
{
    public interface ICustomerService
    {
        Customer Get(int id);
    }
}
