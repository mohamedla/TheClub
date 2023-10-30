using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.NationalityCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/NationalityCodes/")]

    public class NationalityCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public NationalityCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllNationalities))]
        public async Task<IActionResult> GetAllNationalities()
        {
            var nationalities = await _repository.NationalityCode.GetAllAsync(false);

            return Ok(nationalities);
        }

        [HttpPost("", Name = nameof(AddNationality))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddNationality([FromBody] NationalityCodeCreateDTO newNationalityDTO)
        {
            var codeIsExist = await _repository.NationalityCode.GetByCodeAsync(newNationalityDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newNationalityDTO.Code} Already Exist");

            var nationality = _mapper.Map<NationalityCode>(newNationalityDTO);

            _repository.NationalityCode.CreateEntity(nationality);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditNationality))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(NationalityExistValidation))] // check if Nationality exist
        public async Task<IActionResult> EditNationality(Guid Id, [FromBody] NationalityCodeEditDTO updatedNationalityDTO)
        {
            var codeIsExist = await _repository.NationalityCode.GetByCodeAsync(updatedNationalityDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedNationalityDTO.Code} Already Exist");

            var nationality = HttpContext.Items["entity"] as NationalityCode;

            _mapper.Map(updatedNationalityDTO, nationality);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveNationality))]
        [ServiceFilter(typeof(NationalityExistValidation))] // check if Nationality exist
        public async Task<IActionResult> RemoveNationality(Guid Id)
        {
            var nationality = HttpContext.Items["entity"] as NationalityCode;

            _repository.NationalityCode.DeleteEntity(nationality);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

