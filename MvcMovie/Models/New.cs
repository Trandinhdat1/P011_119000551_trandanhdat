using System.ComponentModel.DataAnnotations;

namespace MvcNew.Models
{
    public class New
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        [Stringlength(200,Minimumlength =50)]
        [Required]
        [System.ComponentModel.Bindable(true)]
        public virtual string ImageUrl { get; set; } = string.Empty;
         public string Content { get; set; }
        [Stringlength(500,Minimumlength =100)]
        [Required]
        public string Author { get; set; }
         public string CreatedAt { get; set; }
       
    }
}