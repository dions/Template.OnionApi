using Example.Domain.Models;
using Example.ProductData;
using Example.Service.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Example.Service.Handlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly ProductDbContext _context;
        public GetAllProductsQueryHandler(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken) =>
            await _context.Products.ToListAsync();
    }
}
