﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    //create contact details 
    public class ContactDetails
    {
        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public long zipCode { get; set; }
        public long phoneNumber { get; set; }
        public string emailAddress { get; set; }

    }
}
