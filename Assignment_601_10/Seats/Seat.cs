using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_601_10.Seats
{
    public enum SeatState
    {
        Available, 
        Reserved   
    }
    internal class Seat
    {
        public string SeatId { get; private set; } // Ví dụ: "A1", "B2"
        public SeatState State { get; set; }

        public Seat(string seatId)
        {
            SeatId = seatId;
            State = SeatState.Available; // Mặc định ghế trống
        }

        public void Reserve()
        {
            if (State == SeatState.Available)
            {
                State = SeatState.Reserved;
            }
            else
            {
                throw new InvalidOperationException($"Seat {SeatId} is already reserved.");
            }
        }

        public void Release()
        {
            if (State == SeatState.Reserved)
            {
                State = SeatState.Available;
            }
        }

        public override string ToString()
        {
            return $"Seat {SeatId}: {State}";
        }
    }
}

