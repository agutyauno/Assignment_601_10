using Assignment_601_10.Seats;
// using Assignment_601_10.Showtimes;
using Assignment_601_10.Customers;
namespace Assignment_601_10.Tickets;
internal class Ticket
{
    string ticketID;
    Showtime showTime;
    Seat seat;
    double price;
    Customer customer;

    public Ticket(string ticketID, Showtime showTime, Seat seat, double price, Customer customer)
    {
        this.ticketID = ticketID;
        this.showTime = showTime;
        this.seat = seat;
        this.price = price;
        this.customer = customer;
    }

    public string TicketID { get => ticketID; set => ticketID = value; }
    public double Price { get => price; set => price = value; }
    internal Showtime ShowTime { get => showTime; set => showTime = value; }
    internal Seat Seat { get => seat; set => seat = value; }
    internal Customer Customer { get => customer; set => customer = value; }

    public void Print()
    {
        Console.WriteLine($"{ticketID} {showTime} {seat} {price} {customer}");
    }
}

internal class Showtime
{
}