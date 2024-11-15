namespace Tarkeep.Models
{
    public class Testimonials
    {
        public int Id { get; set; }
        public string Message { get; set; }

        // Relationship with User
        public int UserId { get; set; }
        public User User { get; set; }

        public bool Status { get; set; }
    }
}
