using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM1.ApplicationCore.Domain
{
    public class Passenger
    {
        public int PassportNumber { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TelNumber { get; set; }
        public String Email { get; set; }
        public int Id { get; set; }
        public ICollection<Flight> Flights { get; set; }

    }
}
