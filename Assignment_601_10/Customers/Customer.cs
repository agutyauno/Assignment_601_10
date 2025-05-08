using Assignment_601_10.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_601_10.Customers
{
    internal class Customer
    {
        int number;
        string name, email;

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public int Number { get => number; set => number = value; }

        public Customer(int number, string name, string email)
        {
            this.number = number;
            this.name = name;
            this.email = email;
            Tickets = new List<Ticket>();
        }

        public List<Ticket> Tickets { get; set; }


        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
            Console.WriteLine(value: $"Khách hàng {Name} đã đặt vé: {ticket.TicketId}");
        }

        public void Print()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Tên: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Số điện thoại: {Number}");
            Console.WriteLine("Danh sách vé:");
            if (Tickets.Count == 0)
            {
                Console.WriteLine("- Không có vé nào.");
            }
            else
            {
                foreach (var ticket in Tickets)
                {
                    Console.WriteLine($"- {ticket}");
                }    
            }
        }
    }
}
