﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.api.Models
{
    public class PersonalDetailsModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Tz { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNum { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }


    }
}
