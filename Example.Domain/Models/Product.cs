using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Example.Domain.Base;

namespace Example.Domain.Models
{
    public class Product : EntityBase
    {
        [StringLength(80, MinimumLength = 4)]
        public string? Name { get; set; }

        [StringLength(80, MinimumLength = 4)]
        public string? Description { get; set; }

        [StringLength(80, MinimumLength = 4)]
        public string? Category { get; set; }

        public bool Active { get; set; } = true;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
    }
}
