using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;
    }
}
