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

    public override string ToString() => $"Ticket #{TicketNumber} - AssignedTo: {AssignedTo}, Issue: {Issue}";
}


class ProcessedTicket : Ticket
{
    public ProcessedTicket(Ticket ticket) : base(ticket.TicketNumber, ticket.AssignedTo, ticket.Issue)
    {
        ProcessDate = DateTime.Now;
    }

    public DateTime ProcessDate { get; }

    public override string ToString()
    {
        return $"{base.ToString()} Process on {ProcessDate}";
    }
}