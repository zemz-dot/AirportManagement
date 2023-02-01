using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { set; get; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public string EffectiveArrival { get; set; }
        public string EstimatedDuration { get; set; }

        public List<Passenger> Passenger { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
