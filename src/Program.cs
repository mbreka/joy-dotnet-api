global using JoyApi.Common.Api;
global using JoyApi.Common.Api.Extensions;
global using JoyApi.Common.Api.Requests;
global using JoyApi.Common.Api.Results;
global using JoyApi.Data;
global using JoyApi.Data.Types;
global using FluentValidation;
global using Microsoft.AspNetCore.Http.HttpResults;
global using Microsoft.EntityFrameworkCore;
global using System.Security.Claims;
using JoyApi;
using Serilog;


Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    Log.Information("Starting web application");
    var builder = WebApplication.CreateBuilder(args);
    builder.AddServices();
    var app = builder.Build();
    await app.Configure();
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}