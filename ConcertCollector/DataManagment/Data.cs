using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertCollector.DataManagment
{

    public class Band
    {
        public string Name { get; set; }
        public string NameExtra { get; set; }
        public string Info { get; set; }
    }

    public class Event
    {
        public ulong ID { get; set; }
        public string Name { get; set; }
        public string NameExtra { get; set; }
        public System.DateTime DateFrom;
        public System.DateTime DateTo;
        public string Location { get; set; }
        public float Cost { get; set; }

        public List<Band> Bands { get; set; }

        public Event()
        {
            Bands = new List<Band>();
        } 
    }

    public class Data
    {
        public List<Event> Events { get; set; }

        public Data()
        {
            Events = new List<Event>();
        }
    }
}
