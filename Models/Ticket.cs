namespace helpdesk_tickets.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        //Customer -- Required: Every ticket belongs to a Customer. A ticket cannot exist without a customer.
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        //IT Staff -- A ticket may or may not be assigned to an IT Staff member. A ticket can exist without an IT Staff member.
        public int? ITStaffId { get; set; }
        public ITStaff? ITStaff { get; set; }

        //Ticket Details
        public required string Subject { get; set; }
        public required string Body { get; set; }

        public override string ToString()
        {
            return $"Ticket Id: {Id}, Customer Id: {CustomerId}, IT Staff Id: {ITStaffId}, Subject: {Subject}, Body: {Body}";
        }
    }
}
