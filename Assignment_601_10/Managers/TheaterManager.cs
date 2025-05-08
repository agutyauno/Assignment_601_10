using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_601_10.Managers
{
    internal class TheaterManager
    {
        private static TheaterManager? instance = null;
        private static readonly object padlock = new object();
        private List<Theater> theaters;
        private TheaterManager()
        {
            theaters = new List<Theater>();
        }

        public static TheaterManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new TheaterManager();
                    }
                    return instance;
                }
            }
        }

        // Methods
        public void Add(Theater theater)
        {
            theaters.Add(theater);
        }

        public void Update(Theater oldTheater, Theater newTheater)
        {
            int index = theaters.IndexOf(oldTheater);
            if (index != -1)
            {
                theaters[index] = newTheater;
            }
        }

        public void Remove(Theater theater)
        {
            theaters.Remove(theater);
        }

        public void PrintAll()
        {
            foreach (Theater theater in theaters)
            {
                theater.Print();
            }
        }

        public void Print(Theater theater)
        {
            theater.Print();
        }
    }

    internal class Theater
    {
        internal void Print()
        {
            throw new NotImplementedException();
        }
    }
}
