using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public int Salary { get; set; }
        public DateTime EmployementDate { get; set; }
        public string Function { set; get; }

        public override string? ToString()
        {
            return base.ToString();
        }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a passenger I am a Staff Member");
        }
    }
}
