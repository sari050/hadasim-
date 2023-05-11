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
  public  class CoronaDetailsService: ICoronaDetailsService
    {
        private readonly ICoronaDetailsRepository _coronaDetails;
        private readonly IMapper _mapper;

        public CoronaDetailsService(ICoronaDetailsRepository coronaDetails, IMapper mapper)
        {
            _coronaDetails = coronaDetails;
            _mapper = mapper;
        }

        public async Task<CoronaDetailsDTO> AddAsync(int Id, DateTime? FirstVaccination, DateTime? SecondVaccination,
            DateTime? ThreeVaccination, DateTime? FourthVaccination, string FirstProducer,
          string SecondProducer, string ThreeProducer, string FourthProducer, DateTime? DateOfPositiveResult, DateTime? DateOfRecovery)
        {
            return _mapper.Map<CoronaDetailsDTO>(await _coronaDetails.AddAsync(Id,FirstVaccination,SecondVaccination,ThreeVaccination,FourthVaccination,FirstProducer,
                SecondProducer,ThreeProducer,FourthProducer,DateOfPositiveResult,DateOfRecovery));
        }

        public async Task<List<CoronaDetailsDTO>> GetAllAsync()
        {
            return _mapper.Map<List<CoronaDetailsDTO>>(await _coronaDetails.GetAllAsync());
        }

        public async Task<CoronaDetailsDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<CoronaDetailsDTO>(await _coronaDetails.GetByIdAsync(id));
        }
    }
}
