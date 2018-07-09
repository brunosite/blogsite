using System.ComponentModel.DataAnnotations;

namespace Domain.Category
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
    }
}