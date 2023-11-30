using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.CityCodes;
using ClubEntities.DataTransferObjects.QualificationCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/QualificationCodes/")]

    public class QualificationCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public QualificationCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllQualifications))]
        public async Task<IActionResult> GetAllQualifications()
        {
            var qualifications = await _repository.QualificationCode.GetAllAsync(false);
            var qualificationsDTO = _mapper.Map<IEnumerable<QualificationCodeDTO>>(qualifications);
            return Ok(qualificationsDTO);
        }

        [HttpPost("", Name = nameof(AddQualification))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddQualification([FromBody] QualificationCodeCreateDTO newQualificationDTO)
        {
            var codeIsExist = await _repository.QualificationCode.GetByCodeAsync(newQualificationDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newQualificationDTO.Code} Already Exist");

            var qualification = _mapper.Map<QualificationCode>(newQualificationDTO);

            _repository.QualificationCode.CreateEntity(qualification);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditQualification))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(QualificationExistValidation))] // check if Qualification exist
        public async Task<IActionResult> EditQualification(Guid Id, [FromBody] QualificationCodeEditDTO updatedQualificationDTO)
        {
            var codeIsExist = await _repository.QualificationCode.GetByCodeAsync(updatedQualificationDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedQualificationDTO.Code} Already Exist");

            var qualification = HttpContext.Items["entity"] as QualificationCode;

            _mapper.Map(updatedQualificationDTO, qualification);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveQualification))]
        [ServiceFilter(typeof(QualificationExistValidation))] // check if Qualification exist
        public async Task<IActionResult> RemoveQualification(Guid Id)
        {
            var qualification = HttpContext.Items["entity"] as QualificationCode;

            _repository.QualificationCode.DeleteEntity(qualification);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

