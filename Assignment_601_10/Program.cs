using System;

namespace Assignment_601_10;

    static void Main(string[] args)

        public class Program
    {
        public static void Main()
        {
            // Create movie
            var movie = new Movie("Sample Movie");

            // Create showtime
            var showtime = new Showtime("ST001", movie, DateTime.Now, 10);

            // Initialize managers
            var seatManager = new SeatManager(showtime.Seats);
            var showtimeManager = new ShowtimeManager();
            showtimeManager.AddShowtime(showtime);

            // Test seat reservation
            Console.WriteLine("Available seats: " + seatManager.GetAvailableSeats().Count);
            seatManager.ReserveSeat("S001");
            Console.WriteLine("Available seats after reserving S001: " + seatManager.GetAvailableSeats().Count);
            seatManager.CancelSeat("S001");
            Console.WriteLine("Available seats after canceling S001: " + seatManager.GetAvailableSeats().Count);
        }
    }


