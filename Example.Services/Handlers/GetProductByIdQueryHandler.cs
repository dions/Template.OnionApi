using Example.Domain.Models;
using Example.ProductData;
using Example.Service.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Example.Service.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly ProductDbContext _context;
        public GetProductByIdQueryHandler(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) => 
            await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
    }
}
