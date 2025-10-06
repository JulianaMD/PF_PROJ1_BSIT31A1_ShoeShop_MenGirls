using System.ComponentModel.DataAnnotations;

namespace ShoeShop_WebDesigner.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Contact { get; set; }

        [EmailAddress]
        public required string Email { get; set; }
        public string? ContactNumber { get; internal set; }
    }
}