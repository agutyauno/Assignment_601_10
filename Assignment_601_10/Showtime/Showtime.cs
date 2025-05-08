using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_601_10.Movies;
using Assignment_601_10.Seats;

namespace Assignment_601_10.Showtime
{
    public class Showtime
    {
        public string ShowtimeId { get; }
        public Movie Movie { get; }
        public DateTime StartTime { get; }
        public List<Seat> Seats { get; }

        public Showtime(string showtimeId, Movie movie, DateTime startTime, int seatCount)
        {
            ShowtimeId = showtimeId;
            Movie = movie;
            StartTime = startTime;
            Seats = new List<Seat>();
            for (int i = 1; i <= seatCount; i++)
            {
                Seats.Add(new Seat($"S{i:D3}"));
            }
        }
    }
}