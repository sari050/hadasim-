using Microsoft.AspNetCore.Mvc;
using project.api.Models;
using Project.Common.DTOs;
using Project.Services.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDetailsController : ControllerBase
    {

        private readonly IPersonalDeailsService _personal;

        public PersonalDetailsController(IPersonalDeailsService personal)
        {
            _personal = personal;
        }
        [HttpGet]
        public async Task<List<PersonalDetailsDTO>> Get()
        {
            return await _personal.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<PersonalDetailsDTO> GetById(int id)
        {
            return await _personal.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task Post([FromBody] PersonalDetailsModel personalDetailsModel)
        {
            await _personal.AddAsync(personalDetailsModel.FirstName, personalDetailsModel.LastName, personalDetailsModel.Id,
                personalDetailsModel.Tz, personalDetailsModel.City, personalDetailsModel.Street, personalDetailsModel.StreetNum,
                personalDetailsModel.BirthDate, personalDetailsModel.Phone, personalDetailsModel.MobilePhone);
        }

    }
}