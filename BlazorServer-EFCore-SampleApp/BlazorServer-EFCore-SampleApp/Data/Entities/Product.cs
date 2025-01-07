using System.ComponentModel.DataAnnotations;

namespace BlazorServer_EFCore_SampleApp.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }

}
