using Application.Repository;
using Application;
using Infrastructure;
using Infrastructure.Repository;
using API.Service;
using Application.Interface;
using Application.Service;
using Microsoft.AspNetCore.Hosting;
using API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddWebAPIService(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
