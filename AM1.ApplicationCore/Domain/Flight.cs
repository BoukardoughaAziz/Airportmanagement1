using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM1.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffictiveArrival { get; set; }
        public String Departure { get; set; }
        public String Destination { get; set; }
        public Plane  Plane { get; set; }
        public ICollection<Passenger> Passengers { get; set;}

    }
}
