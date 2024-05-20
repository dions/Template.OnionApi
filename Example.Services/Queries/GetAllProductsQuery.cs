using Example.Domain.Models;
using MediatR;

namespace Example.Service.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
