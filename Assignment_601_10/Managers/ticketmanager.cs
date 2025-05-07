using Assignment_601_10.Tickets;

namespace Assignment_601_10.Managers;
internal class TicketManager
{
    private readonly List<Ticket> tickets = new();

    public void AddTicket(Ticket ticket)
    {
        tickets.Add(ticket);
    }

    public void RemoveTicket(string ticketID)
    {
        Ticket ticketToRemove = tickets.FirstOrDefault(t => t.TicketID == ticketID);
        if (ticketToRemove != null)
        {
            tickets.Remove(ticketToRemove);
        }
    }

    public Ticket GetTicket(string ticketID)
    {
        return tickets.FirstOrDefault(t => t.TicketID == ticketID);
    }

    public List<Ticket> GetAllTickets()
    {
        return tickets;
    }
}
