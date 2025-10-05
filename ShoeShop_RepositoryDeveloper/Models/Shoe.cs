using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShoeShop.Models
{
    public class Shoe
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Brand { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public int Stock { get; set; }

        public List<ShoeColorVariation> ColorVariations { get; set; }
    }
}