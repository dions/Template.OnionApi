using Example.Domain.Models;
using Example.Service.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Example.WebApi.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController
    {
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        private IMediator _mediator;

        [HttpGet(Name = "GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var command = new GetAllProductsQuery();
            var response = await _mediator.Send(command);
            return (IActionResult)(response is not null ? Results.Ok(response) : Results.NotFound());
        }

        [HttpGet("{id}", Name = "GetProductById")]
        public Customer GetProductById(int id)
        {
            return new Customer(id);
        }
    }
}
