using Assignment_601_10.Seats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_601_10.Theaters
{
    internal class Theater 
    {
        public string Name { get; private set; }
        public int SeatCount { get; private set; }
        public List<Seat> Seats { get; private set; }

        public Theater(string name, int seatCount)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            SeatCount = seatCount > 0 ? seatCount : throw new ArgumentException("Seat count must be positive.", nameof(seatCount));
            Seats = new List<Seat>();
            InitializeSeats();
        }

        // Khởi tạo danh sách ghế
        private void InitializeSeats()
        {
            char row = 'A';
            int seatsPerRow = 10; 
            int currentSeatCount = 0;

            while (currentSeatCount < SeatCount)
            {
                for (int i = 1; i <= seatsPerRow && currentSeatCount < SeatCount; i++)
                {
                    string seatId = $"{row}{i}";
                    Seats.Add(new Seat(seatId));
                    currentSeatCount++;
                }
                row++;
            }
        }

        // In thông tin phòng chiếu
        public void Print()
        {
            Console.WriteLine($"Theater: {Name}");
            Console.WriteLine($"Total Seats: {SeatCount}");
            Console.WriteLine("Seat Status:");
            foreach (var seat in Seats)
            {
                Console.WriteLine(seat.ToString());
            }
            Console.WriteLine();
        }
    }
}
