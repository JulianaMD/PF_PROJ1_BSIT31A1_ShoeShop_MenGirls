using System.ComponentModel.DataAnnotations;

namespace ShoeShop.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }
    }
}