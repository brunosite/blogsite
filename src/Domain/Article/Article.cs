using System.ComponentModel.DataAnnotations;

namespace Domain.Article
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
    }
}