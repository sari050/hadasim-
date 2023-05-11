using AutoMapper;
using Project.Common.DTOs;
using Project.Repository.Interface;
using Project.Services.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Services
{
  public  class PersonalDetailsService : IPersonalDeailsService

    {
        private readonly IPersonalDetailsRepository _personalDetails;
        private readonly IMapper _mapper;

        public PersonalDetailsService(IPersonalDetailsRepository personalDetails, IMapper mapper)
        {
            _personalDetails = personalDetails;
            _mapper = mapper;
        }

        public async Task<PersonalDetailsDTO> AddAsync(string FirstName, string LastName, int Id,string Tz, string City, string Street, int StreetNum, DateTime BirthDeate, string Phone, string MobilePhone)
        {
            return _mapper.Map<PersonalDetailsDTO>(await _personalDetails.AddAsync(FirstName, LastName, Id,Tz, City, Street, StreetNum, BirthDeate, Phone, MobilePhone));
        }

        public async Task<List<PersonalDetailsDTO>> GetAllAsync()
        {
            return _mapper.Map<List<PersonalDetailsDTO>>(await _personalDetails.GetAllAsync());
        }

        public async Task<PersonalDetailsDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<PersonalDetailsDTO>(await _personalDetails.GetByIdAsync(id));
        }
    }
}
