using AutoMapper;
using ClubAPI.ActionFilter;
using ClubAPI.ActionFilter.GeneralCodes;
using ClubContracts;
using ClubEntities.DataTransferObjects.TransferCodes;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;

namespace ClubAPI.Controllers.GeneralCodes
{
    [ApiController]
    [Route("api/TransferCodes/")]

    public class TransferCodesController : Controller
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TransferCodesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("", Name = nameof(GetAllTransfers))]
        public async Task<IActionResult> GetAllTransfers()
        {
            var transfers = await _repository.TransferCode.GetAllAsync(false);

            return Ok(transfers);
        }

        [HttpPost("", Name = nameof(AddTransfer))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        public async Task<IActionResult> AddTransfer([FromBody] TransferCodeCreateDTO newTransferDTO)
        {
            var codeIsExist = await _repository.TransferCode.GetByCodeAsync(newTransferDTO.Code, false);

            if (codeIsExist.Count() > 0)
                return Conflict($"The Code {newTransferDTO.Code} Already Exist");

            var transfer = _mapper.Map<TransferCode>(newTransferDTO);

            _repository.TransferCode.CreateEntity(transfer);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}", Name = nameof(EditTransfer))]
        [ServiceFilter(typeof(ModelStateValidationFilter))] // check null and model state
        [ServiceFilter(typeof(TransferExistValidation))] // check if Transfer exist
        public async Task<IActionResult> EditTransfer(Guid Id, [FromBody] TransferCodeEditDTO updatedTransferDTO)
        {
            var codeIsExist = await _repository.TransferCode.GetByCodeAsync(updatedTransferDTO.Code, false);

            if (codeIsExist.Where(e => e.Id != Id).Count() > 0 )
                return Conflict($"The Code {updatedTransferDTO.Code} Already Exist");

            var transfer = HttpContext.Items["entity"] as TransferCode;

            _mapper.Map(updatedTransferDTO, transfer);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}", Name = nameof(RemoveTransfer))]
        [ServiceFilter(typeof(TransferExistValidation))] // check if Transfer exist
        public async Task<IActionResult> RemoveTransfer(Guid Id)
        {
            var transfer = HttpContext.Items["entity"] as TransferCode;

            _repository.TransferCode.DeleteEntity(transfer);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}

