using ClubContracts;
using ClubEntities.DataTransferObjects.Member;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ClubAPI.ActionFilter.GeneralCodes
{
    public class TitleExistValidation : IAsyncActionFilter
    {
        private readonly ILoggerManager _Logger;
        private readonly IRepositoryManager _repository;
        public TitleExistValidation(ILoggerManager logger, IRepositoryManager repository)
        {
            _Logger = logger;
            _repository = repository;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var member = context.ActionArguments.SingleOrDefault(x => x.Key.ToString().Contains("MemberDTO")).Value as MemberDataManipulationDTO;

            if (member == null)
            {
                await MainActionFilters<TitleCode>.CheckEntityExists(context, next, _Logger, _repository.TitleCode.GetByIdAsync);
            }
            else
            {
                await MainActionFilters<TitleCode>.CheckEntityExistsForMember(context, next, _Logger, _repository.TitleCode.GetByIdAsync, member.Title, "Title");
            }
        }
    }
}
