using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Delivery_Service.API.Filters
{
    public class RequestBodyActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {

        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Request body - " + context.HttpContext.Request.Body);
        }
    }
}
