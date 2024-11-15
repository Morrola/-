using System.Collections.Generic;

namespace Tarkeep.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

        // Navigation property for Bookings
        public ICollection<Booking> Bookings { get; set; }
    }
}
