using System;
using System.Net;
using BilgeadamEgitim.WebAPI.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BilgeadamEgitim.WebAPI.Filters
{
    public class ApiExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is NotFoundException)
            {
                // handle explicit 'known' API errors
                var ex = context.Exception as NotFoundException;
                context.Exception = null;

                context.Result = new JsonResult(ex.Message);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            if (context.Exception is NullReferenceException)
            {
                // handle explicit 'known' API errors
                var ex = context.Exception as NullReferenceException;
                context.Exception = null;

                context.Result = new JsonResult(ex.Message);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            //else if (context.Exception is BadRequestException)
            //{
            //    // handle explicit 'known' API errors
            //    var ex = context.Exception as BadRequestException;
            //    context.Exception = null;

            //    context.Result = new JsonResult(ex.Message);
            //    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            //}
            //else if (context.Exception is UnauthorizedAccessException)
            //{
            //    context.Result = new JsonResult(context.Exception.Message);
            //    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            //}
            //else if (context.Exception is ForbiddenException)
            //{
            //    context.Result = new JsonResult(context.Exception.Message);
            //    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            //}


            base.OnException(context);
        }
    }
}