using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.TitleCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/TitleCodes/")]

    public class TitleCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TitleCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllTitles))]
        public async Task<IActionResult> GetAllTitles()
        {
            var titles = await _repository.TitleCode.GetAllAsync(false);

            return Ok(titles);
        }

        [HttpPost("", Name = nameof(AddTitle))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddTitle([FromBody] TitleCodeCreateDTO newTitleDTO)
        {
            var codeIsExist = await _repository.TitleCode.GetByCodeAsync(newTitleDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newTitleDTO.Code} Already Exist");

            var title = _mapper.Map<TitleCode>(newTitleDTO);

            _repository.TitleCode.CreateEntity(title);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditTitle))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(TitleExistValidation))] // check if Title exist
        public async Task<IActionResult> EditTitle(Guid Id, [FromBody] TitleCodeEditDTO updatedTitleDTO)
        {
            var codeIsExist = await _repository.TitleCode.GetByCodeAsync(updatedTitleDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedTitleDTO.Code} Already Exist");

            var title = HttpContext.Items["entity"] as TitleCode;

            _mapper.Map(updatedTitleDTO, title);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveTitle))]
        [ServiceFilter(typeof(TitleExistValidation))] // check if Title exist
        public async Task<IActionResult> RemoveTitle(Guid Id)
        {
            var title = HttpContext.Items["entity"] as TitleCode;

            _repository.TitleCode.DeleteEntity(title);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

