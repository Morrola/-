using System;

namespace Tarkeep.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Num { get; set; }

        // Relationship with User
        public int UserId { get; set; }
        public User User { get; set; }

        // Relationship with Service
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
