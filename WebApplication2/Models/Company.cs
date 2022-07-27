using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("Companies")]
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<User> Users { get; set; } = new List<User>();
    }
}
