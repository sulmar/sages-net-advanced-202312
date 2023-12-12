namespace QueueExample;

class SupportTicketService
{
    private readonly Queue<Ticket> _ticketsQueue = new Queue<Ticket>();
    private readonly List<ProcessedTicket> _processedTickets = new List<ProcessedTicket>();

    public void SubmitTicket(Ticket ticket)
    {
        _ticketsQueue.Enqueue(ticket);

        Console.WriteLine($"New ticket submitted: {ticket}");
    }

    public Ticket ProcessTicket()
    {
        if (_ticketsQueue.Count > 0)
        {
            Ticket ticket = _ticketsQueue.Dequeue();
            _processedTickets.Add(new ProcessedTicket(ticket));

            return ticket;
        }
        else
            return null;
    }

    public IEnumerable<Ticket> GetOpenedTickets()
    {
        return _ticketsQueue;
    }

    public IEnumerable<ProcessedTicket> GetClosedTickets()
    {
        return _processedTickets;
    }
}