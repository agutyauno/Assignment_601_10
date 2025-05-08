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

    public interface ISeatState
    {
        void Reserve(Seat seat);
        void Cancel(Seat seat);
    }

    public class AvailableState : ISeatState
    {
        public void Reserve(Seat seat)
        {
            seat.State = SeatState.Reserved;
            seat.CurrentState = new ReservedState();
            seat.NotifyObservers();
        }

        public void Cancel(Seat seat)
        {
            // No action needed for available seat
        }
    }

    public class ReservedState : ISeatState
    {
        public void Reserve(Seat seat)
        {
            // Seat already reserved
        }

        public void Cancel(Seat seat)
        {
            seat.State = SeatState.Available;
            seat.CurrentState = new AvailableState();
            seat.NotifyObservers();
        }
    }

    // Observer Pattern for Seat
    public interface ISeatObserver
    {
        void Update(Seat seat);
    }

    public class Seat
    {
        private readonly List<ISeatObserver> _observers = new List<ISeatObserver>();
        public string SeatId { get; }
        public SeatState State { get; set; }
        public ISeatState CurrentState { get; set; }

        public Seat(string seatId)
        {
            SeatId = seatId;
            State = SeatState.Available;
            CurrentState = new AvailableState();
        }

        public void Reserve()
        {
            CurrentState.Reserve(this);
        }

        public void Cancel()
        {
            CurrentState.Cancel(this);
        }

        public void Attach(ISeatObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(ISeatObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }