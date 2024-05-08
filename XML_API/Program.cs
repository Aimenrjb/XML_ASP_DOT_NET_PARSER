using XML_API.Core.Interfaces;
using Infrastructure.Persistence;
using XML_API.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

var builder = WebApplication.CreateBuilder(args);
// Configuration des bases de données
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
    opt.UseSqlServer("Server=localhost;Database=XML_parser_DB;Integrated Security=True;TrustServerCertificate=True"));
//.UseSqlServer(@"Server=tcp:mydatabase2701.database.windows.net,1433;Initial Catalog=dbmourad;Persist Security Info=False;User ID=arejeb;Password=chAkayu5r5d!a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));
//opt.UseSqlite("Filename=MyDatabase.db"));
// Add services to the container.
builder.Services.AddScoped<OntologyService,OntologyService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
app.UseCors(corsPolicyBuilder =>
    corsPolicyBuilder.WithOrigins("https://localhost:7061")
    
                     .AllowAnyMethod()
                     .AllowAnyHeader()
);
app.UseAuthorization();

app.MapControllers();

app.Run();
