using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.CityCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/CityCodes/")]

    public class CityCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CityCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllCities))]
        public async Task<IActionResult> GetAllCities()
        {
            var cities = await _repository.CityCode.GetAllAsync(false);

            return Ok(cities);
        }

        [HttpPost("", Name = nameof(AddCity))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddCity([FromBody] CityCodeCreateDTO newCityDTO)
        {
            var codeIsExist = await _repository.CityCode.GetByCodeAsync(newCityDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newCityDTO.Code} Already Exist");

            var city = _mapper.Map<CityCode>(newCityDTO);

            _repository.CityCode.CreateEntity(city);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditCity))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(CityExistValidation))] // check if city exist
        public async Task<IActionResult> EditCity(Guid Id, [FromBody] CityCodeEditDTO updatedCityDTO)
        {
            var codeIsExist = await _repository.CityCode.GetByCodeAsync(updatedCityDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedCityDTO.Code} Already Exist");

            var city = HttpContext.Items["city"] as CityCode;

            _mapper.Map(updatedCityDTO, city);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveCity))]
        [ServiceFilter(typeof(CityExistValidation))] // check if city exist
        public async Task<IActionResult> RemoveCity(Guid Id)
        {
            var city = HttpContext.Items["city"] as CityCode;

            _repository.CityCode.DeleteEntity(city);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

