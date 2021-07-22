using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int PositionId { get; set; }
        public int ShopId { get; set; }

        //Navigation
        public virtual Shop Shop { get; set; }
        public virtual Position Position { get; set; }
    }
}