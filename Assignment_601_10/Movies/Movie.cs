using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_601_10.Movies
{
    internal class Movie
    {
        public string MovieId { get; private set; }
        public string Name { get; private set; }
        public string Genre { get; private set; }
        public int Duration { get; private set; }

        public Movie(string movieId, string name, string genre, int duration)
        {
            MovieId = movieId;
            Name = name;
            Genre = genre;
            Duration = duration;
        }
        public void Print()
        {
            Console.WriteLine($"Movie ID: {MovieId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Duration: {Duration} minutes");
            Console.WriteLine("------------------------");
        }
    }
}
