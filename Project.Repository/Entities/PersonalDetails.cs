using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Entities
{
  public  class PersonalDetails
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
       
        public PersonalDetails(string firstName, string lastName, int id,string tz, string city, string street, int streetNum, DateTime birthDate, string phone, string mobilePhone)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Tz = tz;
            City = city;
            Street = street;
            StreetNum = streetNum;
            BirthDate = birthDate;
            Phone = phone;
            MobilePhone = mobilePhone;
        }
    }
}
