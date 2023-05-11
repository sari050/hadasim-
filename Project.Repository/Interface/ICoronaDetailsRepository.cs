using Project.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Interface
{
    public interface ICoronaDetailsRepository
    {
        Task<List<CoronaDetails>> GetAllAsync();
        Task<CoronaDetails> GetByIdAsync(int id);
        Task<CoronaDetails> AddAsync(int Id,DateTime? FirstVaccination, DateTime? SecondVaccination,
            DateTime? ThreeVaccination, DateTime? FourthVaccination, string FirstProducer,
          string SecondProducer, string ThreeProducer, string FourthProducer, DateTime? DateOfPositiveResult, DateTime? DateOfRecovery);
    }
   

}
