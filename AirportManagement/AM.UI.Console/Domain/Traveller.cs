using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller:Passenger
    {
        public string HealthInformation { set; get; }
        public string Nationality { set; get; }

        public override string? ToString()
        {
            return base.ToString();
        }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a passenger I'am a Traveller");
        }
    }
}
