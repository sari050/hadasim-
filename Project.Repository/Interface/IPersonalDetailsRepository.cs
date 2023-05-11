using Project.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Interface
{
    public interface IPersonalDetailsRepository
    {
        Task<List<PersonalDetails>> GetAllAsync();
        Task<PersonalDetails> GetByIdAsync(int id);
        Task<PersonalDetails> AddAsync(string FirstName, string LastName,int Id,string tz,string City,string Street,int StreetNum,DateTime BirthDeate,string Phone,string MobilePhone);
    }
}
