using System.Collections.Generic;

namespace Tarkeep.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Role { get; set; }

        // Navigation properties
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Testimonials> Testimonials { get; set; }

        public string ImagePath { get; set; }
    }
}
