using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.ReferenceCodes;
using ClubEntities.DataTransferObjects.SectionCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/SectionCodes/")]

    public class SectionCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SectionCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllSections))]
        public async Task<IActionResult> GetAllSections()
        {
            var sections = await _repository.SectionCode.GetAllAsync(false);
            var sectionsDTO = _mapper.Map<IEnumerable<SectionCodeDTO>>(sections);
            return Ok(sectionsDTO);
        }

        [HttpPost("", Name = nameof(AddSection))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddSection([FromBody] SectionCodeCreateDTO newSectionDTO)
        {
            var codeIsExist = await _repository.SectionCode.GetByCodeAsync(newSectionDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newSectionDTO.Code} Already Exist");

            var section = _mapper.Map<SectionCode>(newSectionDTO);

            _repository.SectionCode.CreateEntity(section);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditSection))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(SectionExistValidation))] // check if Section exist
        public async Task<IActionResult> EditSection(Guid Id, [FromBody] SectionCodeEditDTO updatedSectionDTO)
        {
            var codeIsExist = await _repository.SectionCode.GetByCodeAsync(updatedSectionDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedSectionDTO.Code} Already Exist");

            var section = HttpContext.Items["entity"] as SectionCode;

            _mapper.Map(updatedSectionDTO, section);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveSection))]
        [ServiceFilter(typeof(SectionExistValidation))] // check if Section exist
        public async Task<IActionResult> RemoveSection(Guid Id)
        {
            var section = HttpContext.Items["entity"] as SectionCode;

            _repository.SectionCode.DeleteEntity(section);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

