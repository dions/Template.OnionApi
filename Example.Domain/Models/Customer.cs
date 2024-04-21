using Example.Domain.Base;

namespace Example.Domain.Models
{
    public class Customer: EntityBase
    {
        public Customer(int id) => Id = id;

        public string? Name { get; set; }

        public string? Email { get; set; }
    }
}
