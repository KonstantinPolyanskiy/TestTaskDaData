using System.Net;
using System.Text.Json;
using Serilog;

namespace TestTaskDaData.AddressProcessApi.Api.Middlewares;

public class GlobalErrorHandlingMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            Log.Error(ex, ex.Message);
            
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var err = new
            {
                Message = ex.Message,
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(err));
        }
    }
}