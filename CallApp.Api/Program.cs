using AutoMapper;
using CallApp.Aplication.Abstractions;
using CallApp.Aplication.Implemetation;
using CallApp.Infrastruction;
using CallApp.Infrastruction.Mapper;
using CallApp.Infrastruction.Repository.Abstraction;
using CallApp.Infrastruction.Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AldagiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AldagiDatabase")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IClientService, ClientService>();


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
