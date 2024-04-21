using Example.Domain.Base;

namespace Example.Domain.Models
{
    public class Customer: EntityBase
    {
        public Customer(int id) => Id = id;

        public string? CustomerName { get; set; }
    }
}
