using Project.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Inteface
{
    public interface IPersonalDeailsService
    {
        Task<List<PersonalDetailsDTO>> GetAllAsync();
        Task<PersonalDetailsDTO> GetByIdAsync(int id);
        Task<PersonalDetailsDTO> AddAsync(string FirstName, string LastName, int Id,string Tz, string City, string Street, int StreetNum, DateTime BirthDeate, string Phone, string MobilePhone);
    }
}
