using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.Member;
using ClubModels.Models;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers
{
    [ApiController]
    [Route("api/Members/")]
    public class MemberController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MemberController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllMembers))]
        public async Task<IActionResult> GetAllMembers()
        {
            var members = await _repository.Member.GetAllAsync(false);
            var membersDTO = _mapper.Map<IEnumerable<MemberDataDTO>>(members);
            return Ok(membersDTO);
        }

        [HttpGet("meta", Name = nameof(GetAllMembersMD))]
        public async Task<IActionResult> GetAllMembersMD()
        {
            var members = await _repository.Member.GetAllMetaDataOnlyAsync();
            return Ok(members);
        }

        [HttpGet("{id}", Name = nameof(GetMemberById))]
        [ServiceFilter(typeof(MemberExistValidation))]
        public async Task<IActionResult> GetMemberById(Guid Id)
        {
            var member = HttpContext.Items["member"] as Member;
            var memberDTO = _mapper.Map<MemberDataDTO>(member);
            return Ok(memberDTO);
        }

        [HttpPost("", Name = nameof(AddMember))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(CityExistValidation))]
        [ServiceFilter(typeof(GenderExistValidation))]
        [ServiceFilter(typeof(JobExistValidation))]
        [ServiceFilter(typeof(MartialStatusExistValidation))]
        [ServiceFilter(typeof(MembershipExistValidation))]
        [ServiceFilter(typeof(NationalityExistValidation))]
        [ServiceFilter(typeof(QualificationExistValidation))]
        [ServiceFilter(typeof(ReligionExistValidation))]
        [ServiceFilter(typeof(SectionExistValidation))]
        [ServiceFilter(typeof(TitleExistValidation))]
        public async Task<IActionResult> AddMember([FromBody] MemberDataCreateDTO newMemberDTO)
        {
            var membersByIdNo = await _repository.Member.GetByIdNoAsync(newMemberDTO.IdNo);

            if (membersByIdNo.Count() > 0)
                return Conflict($"The ID Number {newMemberDTO.IdNo} Already Exist");

            var member = _mapper.Map<Member>(newMemberDTO);

            _repository.Member.CreateEntity(member);
            await _repository.SaveAsync();

            var memberDTO = _mapper.Map<MemberDataDTO>(member);
            return CreatedAtRoute(nameof(GetMemberById), new { id = member.Id}, memberDTO);
        }

        [HttpPut("{id}", Name = nameof(EditMember))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(MemberExistValidation))]
        [ServiceFilter(typeof(CityExistValidation))]
        [ServiceFilter(typeof(GenderExistValidation))]
        [ServiceFilter(typeof(JobExistValidation))]
        [ServiceFilter(typeof(MartialStatusExistValidation))]
        [ServiceFilter(typeof(MembershipExistValidation))]
        [ServiceFilter(typeof(NationalityExistValidation))]
        [ServiceFilter(typeof(QualificationExistValidation))]
        [ServiceFilter(typeof(ReligionExistValidation))]
        [ServiceFilter(typeof(SectionExistValidation))]
        [ServiceFilter(typeof(TitleExistValidation))]
        public async Task<IActionResult> EditMember(Guid Id, [FromBody] MemberDataCreateDTO newMemberDTO)
        {
            var membersByIdNo = await _repository.Member.GetByIdNoAsync(newMemberDTO.IdNo);

            if (membersByIdNo.Where(e => e.Id != Id).Count() > 0)
                return Conflict($"The Code {newMemberDTO.IdNo} Already Exist");

            var member = HttpContext.Items["member"] as Member;

            _mapper.Map(newMemberDTO, member);
            await _repository.SaveAsync();

            var memberDTO = _mapper.Map<MemberDataDTO>(member);
            return CreatedAtRoute(nameof(GetMemberById), new { id = member.Id }, memberDTO);
        }

        [HttpDelete("{id}", Name = nameof(DeleteMemberById))]
        [ServiceFilter(typeof(MemberExistValidation))]
        public async Task<IActionResult> DeleteMemberById(Guid Id)
        {
            var member = HttpContext.Items["member"] as Member;

            _repository.Member.DeleteEntity(member);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}
