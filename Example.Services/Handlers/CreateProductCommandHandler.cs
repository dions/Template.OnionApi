using Example.Domain.Models;
using Example.ProductData;
using Example.Service.Commands;
using Example.Service.Queries;
using MediatR;

namespace Example.Service.Handlers
{
    public class CreateProductCommandHandler: IRequestHandler<CreateProductCommand, Product>
    {
        private readonly ProductDbContext _dbContext;

        public CreateProductCommandHandler(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Description = request.Description,
                Category = request.Category,
                Price = request.Price,
            };

            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }
    }
}
