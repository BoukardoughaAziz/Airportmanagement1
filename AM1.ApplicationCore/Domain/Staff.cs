using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM1.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public DateTime ÊmploymentType { get; set; }
        public Double Salary { get; set; }
        public String Function { get; set; }
    }
}
