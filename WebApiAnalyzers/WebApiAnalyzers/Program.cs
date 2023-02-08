using Microsoft.AspNetCore.Mvc;
using WebApiAnalyzers.Conventions;
using WebApiAnalyzers.Middlewares;
using WebApiAnalyzers.Services;

//[assembly: ApiConventionType(typeof(CustomConventions))]

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ExampleService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<GlobalExceptionMiddleware>();

app.MapControllers();

app.Run();
