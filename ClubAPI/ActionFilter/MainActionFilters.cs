using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using ClubContracts;
using ClubModels.Models;

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
                context.Result = new NotFoundObjectResult("No Code Match The Request");
            }
            else
            {
                context.HttpContext.Items.Add("entity", entity);
                await next();
            }
        }

        public static async Task CheckEntityExistsForMember(ActionExecutingContext context, ActionExecutionDelegate next, ILoggerManager Logger, Func<Guid, bool, Task<T>> getEntityById, Guid entityId, string msg)
        {
            if (context.Result == null)
            {
                var entity = await getEntityById(entityId, false);

                if (entity == null)
                {
                    Logger.LogError($"No {typeof(T)} Code With Id : {entityId} Exist In The Database");
                    context.Result = new NotFoundObjectResult($"No {msg} Match The Request");
                }
                else
                {
                    await next();
                }
            }
        }
    }
}
