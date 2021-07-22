using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }
        public int? CategoryId { get; set; }
        public int Quantity { get; set; }
        public bool IsInStock { get; set; }

        //Navigation
        public virtual Category Category { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
    }
}