using Microsoft.AspNetCore.Diagnostics;
using FluentValidation;

namespace BankLab.Api.Middleware;

public sealed class GlobalExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext context, Exception exception, CancellationToken cancellationToken)
    {
        if(exception is not ValidationException validationException)
        {
            return false;
        }

        var errors = validationException.Errors
            .Select(error => new
            {
                Field = error.PropertyName,
                Message = error.ErrorMessage
            })
            .ToArray();

        context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;

        await context.Response.WriteAsJsonAsync(new
        {
            StatusCode = context.Response.StatusCode,
            Success = false,
            Message = "Validation failed.",
            Data = errors
        }, cancellationToken);

        return true;
    }
}
