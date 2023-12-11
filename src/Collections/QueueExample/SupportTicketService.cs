namespace QueueExample;

class SupportTicketService
{
    public void SubmitTicket(Ticket ticket)
    {
        throw new NotImplementedException();

        Console.WriteLine($"New ticket submitted: {ticket}");
    }

    public Ticket ProcessTicket()
    {
        throw new NotImplementedException();        
    }

    public IEnumerable<Ticket> GetOpenedTickets()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Ticket> GetClosedTickets()
    {
        throw new NotImplementedException();
    }
}