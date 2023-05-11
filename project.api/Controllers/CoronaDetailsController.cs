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
    public class CoronaDetailsController : ControllerBase
    {
        private readonly ICoronaDetailsService _corona;

        public CoronaDetailsController(ICoronaDetailsService corona)
        {
            _corona = corona;
        }
        [HttpGet]
        public async Task<List<CoronaDetailsDTO>> Get()
        {
            return await _corona.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<CoronaDetailsDTO> GetById(int id)
        {
            return await _corona.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task Post([FromBody] CoronaDetailsModel coronaDetailsModel)
        {
            await _corona.AddAsync(coronaDetailsModel.Id, coronaDetailsModel.FirstVaccination, coronaDetailsModel.SecondVaccination,
                coronaDetailsModel.ThreeVaccination, coronaDetailsModel.FourthVaccination, coronaDetailsModel.FirstProducer,
                coronaDetailsModel.SecondProducer, coronaDetailsModel.ThreeProducer, coronaDetailsModel.FourthProducer,
                coronaDetailsModel.DateOfPositiveResult, coronaDetailsModel.DateOfRecovery
                );
        }
    }
}
