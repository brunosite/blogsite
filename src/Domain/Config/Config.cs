using System.ComponentModel.DataAnnotations;

namespace Domain.Config
{
    public class Config
    {
        [Key]
        public int Id { get; set; }
    }
}