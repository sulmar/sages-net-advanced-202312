namespace QueueExample;

class Ticket
{
    public int TicketNumber { get; }
    public string AssignedTo { get; }
    public string Issue { get; }

    public Ticket(int ticketNumber, string assignedTo, string issue)
    {
        TicketNumber = ticketNumber;
        AssignedTo = assignedTo;
        Issue = issue;
    }

    public override string ToString() => "Ticket #{TicketNumber} - Customer: {CustomerName}, Issue: {Issue}";
}
