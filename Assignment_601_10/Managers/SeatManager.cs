using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_601_10.Managers
{
    public class SeatManager : ISeatObserver
    {
        private readonly List<Seat> seatS;

        public SeatManager(List<Seat> seats)
        {
            seatS = seats;
            foreach (var seat in seats)
            {
                seat.Attach(this);
            }
        }

        public bool ReserveSeat(string seatId)
        {
            var seat = seats.FirstOrDefault(s => s.SeatId == seatId);
            if (seat == null || seat.State == SeatState.Reserved)
                return false;

            seat.Reserve();
            return true;
        }

        public bool CancelSeat(string seatId)
        {
            var seat = seats.FirstOrDefault(s => s.SeatId == seatId);
            if (seat == null || seat.State == SeatState.Available)
                return false;

            seat.Cancel();
            return true;
        }

        public List<Seat> GetAvailableSeats()
        {
            return seats.Where(s => s.State == SeatState.Available).ToList();
        }

        public void Update(Seat seat)
        {
            Console.WriteLine($"Seat {seat.SeatId} state changed to {seat.State}");
        }
    }
}
