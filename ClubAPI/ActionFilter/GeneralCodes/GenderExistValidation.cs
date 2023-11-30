using ClubContracts;
using ClubEntities.DataTransferObjects.Member;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ClubAPI.ActionFilter.GeneralCodes
{
    public class GenderExistValidation : IAsyncActionFilter
    {
        private readonly ILoggerManager _Logger;
        private readonly IRepositoryManager _repository;
        public GenderExistValidation(ILoggerManager logger, IRepositoryManager repository)
        {
            _Logger = logger;
            _repository = repository;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var member = context.ActionArguments.SingleOrDefault(x => x.Key.ToString().Contains("MemberDTO")).Value as MemberDataManipulationDTO;

            if (member == null)
            {
                await MainActionFilters<GenderCode>.CheckEntityExists(context, next, _Logger, _repository.GenderCode.GetByIdAsync);
            }
            else
            {
                await MainActionFilters<GenderCode>.CheckEntityExistsForMember(context, next, _Logger, _repository.GenderCode.GetByIdAsync, member.Gender, "Gender");
            }
        }
    }
}
