using ClubContracts;
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
            var trackChanges = context.HttpContext.Request.Method.Equals("PUT");

            var cityId = (Guid)context.ActionArguments["Id"];

            var city = await _repository.CityCode.GetByIdAsync(cityId, trackChanges);

            if (city == null)
            {
                _Logger.LogError($"No City Code With Id : {cityId} Exist In The Database");
                context.Result = new NotFoundObjectResult("No City Code Match The Request");
            }
            else
            {
                context.HttpContext.Items.Add("city", city);
                await next();
            }
        }
    }
}
