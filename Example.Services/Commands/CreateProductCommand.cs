﻿using Example.Domain.Models;
using MediatR;

namespace Example.Service.Commands
{
    public class CreateProductCommand : IRequest<Product>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public bool Active { get; set; } = true;
        public decimal Price { get; set; }
    }
}
