using Project.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Inteface
{
  public interface ICoronaDetailsService
    {
        Task<List<CoronaDetailsDTO>> GetAllAsync();
        Task<CoronaDetailsDTO> GetByIdAsync(int id);
        Task<CoronaDetailsDTO> AddAsync(int Id, DateTime? FirstVaccination, DateTime? SecondVaccination,
            DateTime? ThreeVaccination, DateTime? FourthVaccination, string FirstProducer,
          string SecondProducer, string ThreeProducer, string FourthProducer, DateTime? DateOfPositiveResult, DateTime? DateOfRecovery);
    }
}
