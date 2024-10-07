using System.ComponentModel.DataAnnotations.Schema;

namespace Magasin.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; } 
        public decimal TotalAmount { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public virtual Product? Products { get; set; } = null!;
    }
}
