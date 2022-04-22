using System.ComponentModel.DataAnnotations;

namespace MvcCategory.Models
{
    public class Category
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
        [Stringlength(200, Minimumlength =50)]
        [Required]

       
    }
}