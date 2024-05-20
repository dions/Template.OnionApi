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

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet(Name = "GetAllProducts")]
        public async Task<IResult> GetAllProducts()
        {
            var command = new GetAllProductsQuery();
            var response = await _mediator.Send(command);
            return (IResult)(response is not null ? Results.Ok(response) : Results.NotFound());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}", Name = "GetProductById")]
        public async Task<IResult> GetProductById(int id)
        {
            var command = new GetProductByIdQuery(id);
            var response = await _mediator.Send(command);
            return (IResult)(response is not null ? Results.Ok(response) : Results.NotFound());
        }
    }
}
