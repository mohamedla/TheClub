using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.MembershipCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/MembershipCodes/")]

    public class MembershipCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MembershipCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllMembership))]
        public async Task<IActionResult> GetAllMembership()
        {
            var membership = await _repository.MembershipCode.GetAllAsync(false);

            return Ok(membership);
        }

        [HttpPost("", Name = nameof(AddMembership))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddMembership([FromBody] MembershipCodeCreateDTO newMembershipDTO)
        {
            var codeIsExist = await _repository.MembershipCode.GetByCodeAsync(newMembershipDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newMembershipDTO.Code} Already Exist");

            var membership = _mapper.Map<MembershipCode>(newMembershipDTO);

            _repository.MembershipCode.CreateEntity(membership);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditMembership))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(MembershipExistValidation))] // check if Membership exist
        public async Task<IActionResult> EditMembership(Guid Id, [FromBody] MembershipCodeEditDTO updatedMembershipDTO)
        {
            var codeIsExist = await _repository.MembershipCode.GetByCodeAsync(updatedMembershipDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedMembershipDTO.Code} Already Exist");

            var membership = HttpContext.Items["entity"] as MembershipCode;

            _mapper.Map(updatedMembershipDTO, membership);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveMembership))]
        [ServiceFilter(typeof(MembershipExistValidation))] // check if Membership exist
        public async Task<IActionResult> RemoveMembership(Guid Id)
        {
            var membership = HttpContext.Items["entity"] as MembershipCode;

            _repository.MembershipCode.DeleteEntity(membership);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

