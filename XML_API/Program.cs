using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using XML_API.Core.Interfaces;
using Infrastructure.Persistence;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IOntologyService>(provider =>
{
    var xmlFilePath = "ness.owl"; // Define the file path here
    return new OntologyService(xmlFilePath);
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(corsPolicyBuilder =>
    corsPolicyBuilder.WithOrigins("https://localhost:7061")
                     .AllowAnyMethod()
                     .AllowAnyHeader()
);
app.UseAuthorization();

app.MapControllers();

app.Run();
