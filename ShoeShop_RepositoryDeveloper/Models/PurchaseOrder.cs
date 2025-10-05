using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoeShop.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        [ForeignKey("Shoe")]
        public int ShoeId { get; set; }
        public Shoe Shoe { get; set; }

        public int Quantity { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}