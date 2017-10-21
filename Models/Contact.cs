﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String PhonePrimary { get; set; }
        public String PhoneSecondary { get; set; }
        public DateTime Birthday { get; set; }
        public String StreetAddress1 { get; set; }
        public String StreetAddress2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }
    }
}