using JourneySearchContract.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SearchService.Exceptions;
using System.Net;

namespace SearchService.Attributes
{
    public class CustomExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is UnhandledException httpResponseException)
            {
                //need to make this an object and serialise it. 
                var error = new ErrorResponse 
                { 
                    Title = "Unhandle exception",
                    Detail = httpResponseException.Message,
                    Status = (int)HttpStatusCode.BadRequest
                };

                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;          
                context.Result = new JsonResult(error);

                base.OnException(context);
            }       
        }
    }
}
