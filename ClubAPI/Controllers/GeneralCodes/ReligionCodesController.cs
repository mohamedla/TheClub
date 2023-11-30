using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.ReferenceCodes;
using ClubEntities.DataTransferObjects.ReligionCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/ReligionCodes/")]

    public class ReligionCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ReligionCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllReligions))]
        public async Task<IActionResult> GetAllReligions()
        {
            var religions = await _repository.ReligionCode.GetAllAsync(false);
            var religionsDTO = _mapper.Map<IEnumerable<ReligionCodeDTO>>(religions);
            return Ok(religionsDTO);
        }

        [HttpPost("", Name = nameof(AddReligion))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddReligion([FromBody] ReligionCodeCreateDTO newReligionDTO)
        {
            var codeIsExist = await _repository.ReligionCode.GetByCodeAsync(newReligionDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newReligionDTO.Code} Already Exist");

            var religion = _mapper.Map<ReligionCode>(newReligionDTO);

            _repository.ReligionCode.CreateEntity(religion);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditReligion))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(ReligionExistValidation))] // check if Religion exist
        public async Task<IActionResult> EditReligion(Guid Id, [FromBody] ReligionCodeEditDTO updatedReligionDTO)
        {
            var codeIsExist = await _repository.ReligionCode.GetByCodeAsync(updatedReligionDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedReligionDTO.Code} Already Exist");

            var religion = HttpContext.Items["entity"] as ReligionCode;

            _mapper.Map(updatedReligionDTO, religion);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveReligion))]
        [ServiceFilter(typeof(ReligionExistValidation))] // check if Religion exist
        public async Task<IActionResult> RemoveReligion(Guid Id)
        {
            var religion = HttpContext.Items["entity"] as ReligionCode;

            _repository.ReligionCode.DeleteEntity(religion);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

