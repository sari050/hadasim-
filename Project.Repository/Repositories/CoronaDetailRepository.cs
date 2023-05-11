using Microsoft.EntityFrameworkCore;
using Project.Repository.Entities;
using Project.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Repositories
{
   public class CoronaDetailRepository:ICoronaDetailsRepository
    {
        private readonly IContext _context;
        public CoronaDetailRepository(IContext context)
        {
            _context = context;
        }
        public async Task<CoronaDetails> AddAsync(int Id,DateTime? FirstVaccination, DateTime? SecondVaccination,
            DateTime? ThreeVaccination, DateTime? FourthVaccination, string FirstProducer,
          string SecondProducer, string ThreeProducer, string FourthProducer, DateTime? DateOfPositiveResult, DateTime? DateOfRecovery)
        {
            var i = new CoronaDetails(Id,FirstVaccination,SecondVaccination,ThreeVaccination,FourthVaccination,
                FirstProducer,SecondProducer,ThreeProducer,FourthProducer,DateOfPositiveResult,DateOfRecovery);
            _context.coronaDetailss.Add(i);
            await _context.SaveChangesAsync();
            return i;
        }

        public async Task<List<CoronaDetails>> GetAllAsync()
        {
            return await _context.coronaDetailss.ToListAsync();
        }

        public async Task<CoronaDetails> GetByIdAsync(int id)
        {
            return _context.coronaDetailss.FindAsync(id).Result;
        }

        
    }
}
