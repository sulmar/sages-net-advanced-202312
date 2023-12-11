
using Collections.Core;
using QueueExample;

Console.WriteLine("Hello, Queue!");

SupportTicketServiceTest();

static void SupportTicketServiceTest()
{
    SupportTicketService ticketService = new SupportTicketService();

    // Submit support tickets
    ticketService.SubmitTicket(new Ticket(1, "John Doe", "Network Issue"));
    ticketService.SubmitTicket(new Ticket(2, "Jane Smith", "Software Bug"));
    ticketService.SubmitTicket(new Ticket(3, "Bob Johnson", "Hardware Failure"));

    // Display the current state of the queue
    var openedTicket = ticketService.GetOpenedTickets();

    openedTicket.Dump("Opened Tickets:");

    // Process support tickets
    Ticket processedTicket1 = ticketService.ProcessTicket();
    Ticket processedTicket2 = ticketService.ProcessTicket();

    // Display the updated state of the queue
    openedTicket = ticketService.GetOpenedTickets();
    openedTicket.Dump("Opened Tickets:");

    var closedTickets = ticketService.GetClosedTickets();

    closedTickets.Dump("Closed Tickets:");
}

