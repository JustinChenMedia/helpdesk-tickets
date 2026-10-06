using System.Reflection.Metadata.Ecma335;

namespace helpdesk_tickets.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

        public override string ToString()
        {
            return $"Customer Id: {Id}, Name: {Name}, Email: {Email}";
        }
    }
}
