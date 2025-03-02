using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace eStore.Web.Mvc.Filters;

public sealed class SaveLastActivityAttribute: TypeFilterAttribute
{
    public SaveLastActivityAttribute() : base(typeof(SaveLastActivityFilter))
    {
    }
    
    private class SaveLastActivityFilter : IAsyncActionFilter
    {
        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}