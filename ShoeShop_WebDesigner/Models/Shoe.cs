namespace ShoeShop_WebDesigner.Models
{
    public class Shoe
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public required string Color { get; set; }
    }
}