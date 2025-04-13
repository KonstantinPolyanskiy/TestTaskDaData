using Serilog;
using System.Reflection;
using TestTaskDaData.AddressProcessApi.Api.Middlewares;
using TestTaskDaData.AddressProcessApi.Connectors.DaData;
using TestTaskDaData.AddressProcessApi.Services.AddressProcessService;
using TestTaskDaData.AddressProcessApi.Services.PopulationService;
using TestTaskDaData.AddressProcessApi.Shared.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) => lc
    .ReadFrom.Configuration(ctx.Configuration));

builder.Services.Configure<ServiceOptions>(
    builder.Configuration.GetSection("DaDataOptions"));

builder.Services.AddHttpClient<IDaDataClient, DaDataClient>((sp, client) =>
{
    var options = sp.GetRequiredService<Microsoft.Extensions.Options.IOptions<ServiceOptions>>().Value;
    client.BaseAddress = new Uri(options.BaseUrl!);
    client.DefaultRequestHeaders.Add("Authorization", $"Token {options.Token}");
    client.DefaultRequestHeaders.Add("X-Secret", options.Secret);
});

builder.Services.AddScoped<IPopulationService, StubPopulationService>();
builder.Services.AddScoped<IAddressProcessService, DaDataAddressProcessService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("DefaultPolicy", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<GlobalErrorHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("DefaultPolicy");

app.MapControllers();

app.Run();    