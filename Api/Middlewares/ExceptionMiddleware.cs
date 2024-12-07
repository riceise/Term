using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;
using Share.Validations;

namespace Api.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ValidationException ex)
            {
                await HandleExceptionAsync(context, ex, HttpStatusCode.BadRequest);
            }
            catch (CustomValidationException ex)
            {
                await HandleExceptionAsync(context, ex, HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, HttpStatusCode.InternalServerError);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception, HttpStatusCode statusCode)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            var response = new
            {
                message = exception is ValidationException ? "Файл содержит ошибки." : "Произошла ошибка.",
                errors = exception is CustomValidationException customValidationException
                    ? customValidationException.Errors
                    : new[] { exception.Message }
            };

            return context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}

