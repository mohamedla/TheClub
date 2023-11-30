using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.CityCodes;
using ClubEntities.DataTransferObjects.JobCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/JobCodes/")]

    public class JobCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public JobCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllJobs))]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobs = await _repository.JobCode.GetAllAsync(false);
            var jobsDTO = _mapper.Map<IEnumerable<JobCodeDTO>>(jobs);
            return Ok(jobsDTO);
        }

        [HttpPost("", Name = nameof(AddJob))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddJob([FromBody] JobCodeCreateDTO newJobDTO)
        {
            var codeIsExist = await _repository.JobCode.GetByCodeAsync(newJobDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newJobDTO.Code} Already Exist");

            var job = _mapper.Map<JobCode>(newJobDTO);

            _repository.JobCode.CreateEntity(job);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditJob))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(JobExistValidation))] // check if job exist
        public async Task<IActionResult> EditJob(Guid Id, [FromBody] JobCodeEditDTO updatedJobDTO)
        {
            var codeIsExist = await _repository.JobCode.GetByCodeAsync(updatedJobDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedJobDTO.Code} Already Exist");

            var job = HttpContext.Items["entity"] as JobCode;

            _mapper.Map(updatedJobDTO, job);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveJob))]
        [ServiceFilter(typeof(JobExistValidation))] // check if job exist
        public async Task<IActionResult> RemoveJob(Guid Id)
        {
            var job = HttpContext.Items["entity"] as JobCode;

            _repository.JobCode.DeleteEntity(job);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

