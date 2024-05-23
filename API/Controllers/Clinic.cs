using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prn_dentistry.API.controllers
{
    public class Clinic
    {
        public int ClinicID {get;set;}
        public string Name {get;set;}
        public string Address {get;set;}
        public string PhoneNumber{get;set;}
        public string Email {get;set;}
        public DateTime OpeningHours{get;set;}
        public DateTime ClosingHours{get;set;}

    }
}