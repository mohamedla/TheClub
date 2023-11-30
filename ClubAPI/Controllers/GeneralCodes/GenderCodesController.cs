using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.CityCodes;
using ClubEntities.DataTransferObjects.GenderCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/GenderCodes/")]

    public class GenderCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public GenderCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllGenders))]
        public async Task<IActionResult> GetAllGenders()
        {
            var genders = await _repository.GenderCode.GetAllAsync(false);
            var gendersDTO = _mapper.Map<IEnumerable<GenderCodeDTO>>(genders);
            return Ok(gendersDTO);
        }

        [HttpPost("", Name = nameof(AddGender))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddGender([FromBody] GenderCodeCreateDTO newGenderDTO)
        {
            var codeIsExist = await _repository.GenderCode.GetByCodeAsync(newGenderDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newGenderDTO.Code} Already Exist");

            var gender = _mapper.Map<GenderCode>(newGenderDTO);

            _repository.GenderCode.CreateEntity(gender);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditGender))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(GenderExistValidation))] // check if gender exist
        public async Task<IActionResult> EditGender(Guid Id, [FromBody] GenderCodeEditDTO updatedGenderDTO)
        {
            var codeIsExist = await _repository.GenderCode.GetByCodeAsync(updatedGenderDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedGenderDTO.Code} Already Exist");

            var gender = HttpContext.Items["entity"] as GenderCode;

            _mapper.Map(updatedGenderDTO, gender);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveGender))]
        [ServiceFilter(typeof(GenderExistValidation))] // check if gender exist
        public async Task<IActionResult> RemoveGender(Guid Id)
        {
            var gender = HttpContext.Items["entity"] as GenderCode;

            _repository.GenderCode.DeleteEntity(gender);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

