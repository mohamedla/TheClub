using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.CityCodes;
using ClubEntities.DataTransferObjects.ReferenceCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/ReferenceCodes/")]

    public class ReferenceCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ReferenceCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllReferences))]
        public async Task<IActionResult> GetAllReferences()
        {
            var references = await _repository.ReferenceCode.GetAllAsync(false);
            var referencesDTO = _mapper.Map<IEnumerable<ReferenceCodeDTO>>(references);
            return Ok(referencesDTO);
        }

        [HttpPost("", Name = nameof(AddReference))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddReference([FromBody] ReferenceCodeCreateDTO newReferenceDTO)
        {
            var codeIsExist = await _repository.ReferenceCode.GetByCodeAsync(newReferenceDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newReferenceDTO.Code} Already Exist");

            var reference = _mapper.Map<ReferenceCode>(newReferenceDTO);

            _repository.ReferenceCode.CreateEntity(reference);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditReference))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(ReferenceExistValidation))] // check if Reference exist
        public async Task<IActionResult> EditReference(Guid Id, [FromBody] ReferenceCodeEditDTO updatedReferenceDTO)
        {
            var codeIsExist = await _repository.ReferenceCode.GetByCodeAsync(updatedReferenceDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedReferenceDTO.Code} Already Exist");

            var reference = HttpContext.Items["entity"] as ReferenceCode;

            _mapper.Map(updatedReferenceDTO, reference);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveReference))]
        [ServiceFilter(typeof(ReferenceExistValidation))] // check if Reference exist
        public async Task<IActionResult> RemoveReference(Guid Id)
        {
            var reference = HttpContext.Items["entity"] as ReferenceCode;

            _repository.ReferenceCode.DeleteEntity(reference);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

