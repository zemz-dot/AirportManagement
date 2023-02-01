using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PassportNumber { set; get; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }

        public List<Flight> Flight { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }

        public bool CheckProfile(string Fn, string Ln, String Em)
        {
            if (Em==null)
            {
                return Fn == FirstName && Ln == LastName && Em == EmailAdress;
            }
            return Fn == FirstName && Ln == LastName;

        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I'm a passenger");
        }
    }
}

