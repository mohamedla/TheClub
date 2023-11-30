using ClubContracts;
using ClubEntities.DataTransferObjects.Member;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ClubAPI.ActionFilter.GeneralCodes
{
    public class CityExistValidation : IAsyncActionFilter
    {
        private readonly ILoggerManager _Logger;
        private readonly IRepositoryManager _repository;
        public CityExistValidation(ILoggerManager logger, IRepositoryManager repository)
        {
            _Logger = logger;
            _repository = repository;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var member = context.ActionArguments.SingleOrDefault(x => x.Key.ToString().Contains("MemberDTO")).Value as MemberDataManipulationDTO;

            if (member == null)
            {
                await MainActionFilters<CityCode>.CheckEntityExists(context, next, _Logger, _repository.CityCode.GetByIdAsync);
            }
            else
            {
                await MainActionFilters<CityCode>.CheckEntityExistsForMember(context, next, _Logger, _repository.CityCode.GetByIdAsync, member.CityId, "City");

                await MainActionFilters<CityCode>.CheckEntityExistsForMember(context, next, _Logger, _repository.CityCode.GetByIdAsync, member.BirthPlaceId, "Birth Place");
            }
        }
    }
}
