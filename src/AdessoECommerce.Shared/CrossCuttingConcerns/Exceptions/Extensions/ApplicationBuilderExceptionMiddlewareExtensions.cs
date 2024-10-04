using AdessoECommerce.Shared.CrossCuttingConcerns.Exceptions.Middleware;
using Microsoft.AspNetCore.Builder;

namespace AdessoECommerce.Shared.CrossCuttingConcerns.Exceptions.Extensions;

public static class ApplicationBuilderExceptionMiddlewareExtensions
{
    public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();
    }
}