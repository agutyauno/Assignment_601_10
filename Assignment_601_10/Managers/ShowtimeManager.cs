using Assignment_601_10.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_601_10.Managers
{
    public class ShowtimeManager
    {
        private readonly List<Showtime> showtimes;

        public ShowtimeManager()
        {
            showtimes = new List<Showtime>();
        }

        public void AddShowtime(Showtime showtime)
        {
            showtimes.Add(showtime);
        }

        public Showtime GetShowtime(string showtimeId)
        {
            return showtimes.FirstOrDefault(s => s.ShowtimeId == showtimeId);
        }

        public List<Showtime> GetShowtimesByMovie(Movie movie)
        {
            return showtimes.Where(s => s.Movie == movie).ToList();
        }
    }
}
