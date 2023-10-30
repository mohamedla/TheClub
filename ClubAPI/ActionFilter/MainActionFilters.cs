using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using ClubContracts;

namespace ClubAPI.ActionFilter
{
    public static class MainActionFilters<T>
    {
        public static async Task CheckEntityExists(ActionExecutingContext context, ActionExecutionDelegate next, ILoggerManager Logger, Func<Guid, bool, Task<T>> getEntityById)
        {
            var trackChanges = context.HttpContext.Request.Method.Equals("PUT");

            var entityId = (Guid)context.ActionArguments["Id"];

            var entity = await getEntityById(entityId, trackChanges);

            if (entity == null)
            {
                Logger.LogError($"No {typeof(T)} Code With Id : {entityId} Exist In The Database");
                context.Result = new NotFoundObjectResult($"No Code Match The Request");
            }
            else
            {
                context.HttpContext.Items.Add("entity", entity);
                await next();
            }
        }
    }
}
