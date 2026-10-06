namespace helpdesk_tickets.Models
{
    public class ITStaff
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

        public override string ToString()
        {
            return $"IT Staff Id: {Id}, Name: {Name}, Email: {Email}";
        }
    }
}
