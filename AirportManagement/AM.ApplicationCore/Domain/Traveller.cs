﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        public override string ToString()
        {
            return "Name : " + this.FirstName + " " + this.LastName + "; Passport : " + this.PassportNumber + "; Nationality :" + this.Nationality;
        }

        public override string PassengerType()
        {
            return base.PassengerType() + " I am a traveller";
        }
    }
}
