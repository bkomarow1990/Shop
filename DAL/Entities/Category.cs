using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        //Navigation

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}