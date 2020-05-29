using ChallengeNubi.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace ChallengeNubi.Infrastructure.Filters
{
    public class GlobalException : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = (BusinessException)context.Exception;
            var validation = new
            {
                Status = 401,
                Title = "Unauthorized",
                Detail = exception.Message
            };
            var json = new
            {
                errors = new[] { validation }
            };
            context.Result = new BadRequestObjectResult(json);
            ((ObjectResult)context.Result).StatusCode = (int)HttpStatusCode.Unauthorized;
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized; 
            context.ExceptionHandled = true;
        }
    }
}
