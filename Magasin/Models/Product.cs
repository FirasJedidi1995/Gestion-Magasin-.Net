using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Magasin.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        public string Description { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
