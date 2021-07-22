using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        //Navigation
        public virtual ICollection<Worker> Workers { get; set; } = new HashSet<Worker>();
    }
}