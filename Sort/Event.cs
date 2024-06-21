using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursee
{
    public abstract class Event: IComparable<Event>
    {
       
        public string Name { get; set; }
        public string Text { get; set; }
        public string Address { get; set; }
        public double Rent { get; set; }
        public double Time { get; set; }
        public int Guests { get; set; }
        public string Priority { get; set; }
        public bool Prepare { get; set; }

        public DateTime EventDateTime { get; set; }
        public virtual double Price()
        {
            
            return 0.0;
        }
        public double EventPrice => Price();

        public int CompareTo(Event other)
        {
            if (other == null) return 1;
            return this.EventDateTime.CompareTo(other.EventDateTime);
        }
        public Event(string name, string text, string address, double rent, double time, int guests, string priority, bool prepare, DateTime eventDateTime)
    {

            Name = name;
            Text = text;
            Address = address;
            Rent = rent;
            Time = time;
            Guests = guests;
            Priority = priority;
            Prepare = prepare;
            EventDateTime = eventDateTime;
        }

        public Event() { }
    }

    public class EventWithoutGuests : Event
    {
        public EventWithoutGuests(string name, string text, string address, double rent, double time, string priority, bool status, DateTime eventDateTime)
            : base(name, text, address, rent, time, 0, priority, status, eventDateTime)
        {
        }

        public override double Price()
        {
            return Rent * Time;
        }
    }

    public class EventWithGuests : Event
    {
        public double PlacePrice { get; set; }

        public override double Price()
        {
            return (Rent * Time) + (Guests * PlacePrice);
        }

        public EventWithGuests(string name, string text, string address, double rent, double time, int guests, string priority, bool prepare, double placePrice, DateTime eventDateTime)
            : base( name, text, address, rent, time, guests, priority, prepare, eventDateTime)
        {
            PlacePrice = placePrice;
        }
    }
}
