using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoeShop_WebDesigner.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        // Foreign Key
        [Required]
        [Display(Name = "Supplier")]
        public int SupplierId { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier? Supplier { get; set; }
    }
}