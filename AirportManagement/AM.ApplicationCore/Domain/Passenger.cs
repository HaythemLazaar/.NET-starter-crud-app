using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateOnly BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "Name : " + this.FirstName + " " + this.LastName + "; Passport : " + this.PassportNumber;
        }

        public bool CheckProfile(string firstName, string lastName)
        {
            return (firstName == this.FirstName && lastName == this.LastName);
        }

        public bool CheckProfile(string firstName, string lastName, string email)
        {
            return (firstName == this.FirstName 
                && lastName == this.LastName
                && email == this.EmailAdress);
        }

        public bool CheckProfile(Passenger passenger)
        {
            return (this.Equals(passenger));
        }

        public virtual string PassengerType()
        {
            return "I am a passenger";
        }
    }
}
