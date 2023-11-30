using ClubContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ClubAPI.ActionFilter
{
    public class MemberExistValidation : IAsyncActionFilter
    {
        private readonly ILoggerManager _Logger;
        private readonly IRepositoryManager _repository;
        public MemberExistValidation(ILoggerManager logger, IRepositoryManager repository)
        {
            _Logger = logger;
            _repository = repository;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var trackChanges = context.HttpContext.Request.Method.Equals("PUT");

            var memberId = (Guid)context.ActionArguments["Id"];

            var member = await _repository.Member.GetByIdAsync(memberId, trackChanges);

            if (member == null)
            {
                _Logger.LogError($"No Member With Id : {memberId} Exist In The Database");
                context.Result = new NotFoundObjectResult("No Member Match The Request");
            }
            else
            {
                context.HttpContext.Items.Add("member", member);
                await next();
            }
        }
    }
}
