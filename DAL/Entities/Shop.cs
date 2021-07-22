using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Shop
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Adress { get; set; }
        public int CityId { get; set; }
        public int? ParkingArea { get; set; }

        // Navigation
        public virtual City City { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }  = new HashSet<Worker>();
        public override string ToString()
        {
            return $"Name: {Name}, Adress: {Adress}, City: {City.Name}, Country: {City.Country.Name}";
        }
        public virtual ICollection<Product> Products { get; set; }  = new HashSet<Product>();
    }
}
