using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoeShop.Models
{
    public class ShoeColorVariation
    {
        public int Id { get; set; }

        [Required]
        public string Color { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("Shoe")]
        public int ShoeId { get; set; }
        public Shoe Shoe { get; set; }
    }
}