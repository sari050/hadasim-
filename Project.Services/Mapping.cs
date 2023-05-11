using AutoMapper;
using Project.Common.DTOs;
using Project.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services
{
   public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<PersonalDetails, PersonalDetailsDTO>().ReverseMap();
            CreateMap<CoronaDetails, CoronaDetailsDTO>().ReverseMap();
        }
    }
}
