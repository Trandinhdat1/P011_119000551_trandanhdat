using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int Content { get; set; }
        public string Author { get; set; }
        public string CreatedAt { get; set; }
    }
}