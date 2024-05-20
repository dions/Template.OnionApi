using Example.Domain.Models;
using MediatR;

namespace Example.Service.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
