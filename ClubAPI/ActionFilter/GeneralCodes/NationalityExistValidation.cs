using ClubContracts;
using ClubEntities.DataTransferObjects.Member;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ClubAPI.ActionFilter.GeneralCodes
{
    public class NationalityExistValidation : IAsyncActionFilter
    {
        private readonly ILoggerManager _Logger;
        private readonly IRepositoryManager _repository;
        public NationalityExistValidation(ILoggerManager logger, IRepositoryManager repository)
        {
            _Logger = logger;
            _repository = repository;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var member = context.ActionArguments.SingleOrDefault(x => x.Key.ToString().Contains("MemberDTO")).Value as MemberDataManipulationDTO;

            if (member == null)
            {
                await MainActionFilters<NationalityCode>.CheckEntityExists(context, next, _Logger, _repository.NationalityCode.GetByIdAsync);
            }
            else
            {
                await MainActionFilters<NationalityCode>.CheckEntityExistsForMember(context, next, _Logger, _repository.NationalityCode.GetByIdAsync, member.NationalityID, "Nationality");
            }
        }
    }
}
