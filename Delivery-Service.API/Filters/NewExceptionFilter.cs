using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Delivery_Service.API.Filters
{
    public class NewExceptionFilter : IExceptionFilter
    {
        private readonly ILogger _logger;

        public NewExceptionFilter(ILogger logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogInformation(context.Exception.StackTrace);
        }
    }
}
