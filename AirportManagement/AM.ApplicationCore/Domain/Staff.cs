using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public float Salary { get; set; }

        public override string ToString()
        {
            return "Name :" + this.FirstName + " " + this.LastName + "; Function : " + this.Function;
        }

        public override string PassengerType()
        {
            return base.PassengerType() + " I am a Staff Member";
        }
    }
}
