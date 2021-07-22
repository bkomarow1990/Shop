using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWPF.MappingClasses
{
    class ShopModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int CityId { get; set; }
        public int? ParkingArea { get; set; }

        // Navigation
        public virtual City City { get; set; }
        public virtual ICollection<Worker> Workers { get; set; } = new HashSet<Worker>();
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
