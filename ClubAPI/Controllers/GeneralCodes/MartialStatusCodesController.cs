using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.CityCodes;
using ClubEntities.DataTransferObjects.MartialStatusCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/MartialStatusCodes/")]

    public class MartialStatusCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MartialStatusCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllMartialStatus))]
        public async Task<IActionResult> GetAllMartialStatus()
        {
            var martialStatus = await _repository.MartialStatusCode.GetAllAsync(false);
            var martialStatusDTO = _mapper.Map<IEnumerable<MartialStatusCodeDTO>>(martialStatus);
            return Ok(martialStatusDTO);
        }

        [HttpPost("", Name = nameof(AddMartialStatus))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddMartialStatus([FromBody] MartialStatusCodeCreateDTO newMartialDTO)
        {
            var codeIsExist = await _repository.MartialStatusCode.GetByCodeAsync(newMartialDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newMartialDTO.Code} Already Exist");

            var martialStatus = _mapper.Map<MartialStatusCode>(newMartialDTO);

            _repository.MartialStatusCode.CreateEntity(martialStatus);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditMartialStatus))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(MartialStatusExistValidation))] // check if MartialStatus exist
        public async Task<IActionResult> EditMartialStatus(Guid Id, [FromBody] MartialStatusCodeEditDTO updatedMartialStatusDTO)
        {
            var codeIsExist = await _repository.MartialStatusCode.GetByCodeAsync(updatedMartialStatusDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedMartialStatusDTO.Code} Already Exist");

            var martialStatus = HttpContext.Items["entity"] as MartialStatusCode;

            _mapper.Map(updatedMartialStatusDTO, martialStatus);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveMartialStatus))]
        [ServiceFilter(typeof(MartialStatusExistValidation))] // check if MartialStatus exist
        public async Task<IActionResult> RemoveMartialStatus(Guid Id)
        {
            var martialStatus = HttpContext.Items["entity"] as MartialStatusCode;

            _repository.MartialStatusCode.DeleteEntity(martialStatus);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

