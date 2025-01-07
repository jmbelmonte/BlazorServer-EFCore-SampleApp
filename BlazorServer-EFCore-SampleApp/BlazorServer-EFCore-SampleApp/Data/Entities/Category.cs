using System.ComponentModel.DataAnnotations;

namespace BlazorServer_EFCore_SampleApp.Data.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = default!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }

}
