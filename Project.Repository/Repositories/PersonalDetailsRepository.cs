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
   public class PersonalDetailsRepository: IPersonalDetailsRepository
    {
        private readonly IContext _context;
        public PersonalDetailsRepository(IContext context)
        {
            _context = context;
        }
        public async Task<PersonalDetails> AddAsync(string FirstName, string LastName, int Id,string Tz, string City, string Street, int StreetNum, DateTime BirthDeate, string Phone, string MobilePhone)
        {
            var i = new PersonalDetails(FirstName, LastName, Id,Tz,City,Street,StreetNum,BirthDeate,Phone,MobilePhone) ;
            _context.personalDetailss.Add(i);
            await _context.SaveChangesAsync();
            return i;
        }

        public async Task<List<PersonalDetails>> GetAllAsync()
        {
            return await _context.personalDetailss.ToListAsync();
        }

        public async Task<PersonalDetails> GetByIdAsync(int id)
        {
            return _context.personalDetailss.FindAsync(id).Result;
        }
    }
}
