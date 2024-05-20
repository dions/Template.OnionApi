using Example.Domain.Models;
using MediatR;

namespace Example.Service.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
