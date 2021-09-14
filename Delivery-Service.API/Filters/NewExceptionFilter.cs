using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Delivery_Service.API.Filters
{
    public class NewExceptionFilter : IExceptionFilter
    {
        private readonly ILogger _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public NewExceptionFilter(ILogger logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public void OnException(ExceptionContext context)
        {
           // _logger.LogInformation(context.Exception.StackTrace);

            if (_webHostEnvironment.IsDevelopment())
            {
                _logger.LogInformation($"Error - {context.Exception.Message} {context.Exception.StackTrace}");
            }

            if (_webHostEnvironment.IsEnvironment("QA"))
            {
                _logger.LogInformation($"Error - {context.Exception.Message}");
            }

            context.ExceptionHandled = true;
        }



    }
}
