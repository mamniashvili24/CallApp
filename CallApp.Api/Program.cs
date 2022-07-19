using CallApp.Api.Model;
using Microsoft.EntityFrameworkCore;
using CallApp.Aplication.Abstractions;
using CallApp.Infrastruction.Database;
using CallApp.Aplication.Implemetation;
using CallApp.Infrastruction.Entity.Database;
using CallApp.Domain.Respons.Models.Impementation;
using CallApp.Infrastruction.Repository.Abstraction;
using CallApp.Infrastruction.Repository.Implementation;
using CallApp.Aplication.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(o =>
{
    o.CreateMap<Person, BaseInfoModel>();
    o.CreateMap<BaseInfoModel, Person>();
    o.CreateMap<EmailModel, NotificationModel>();
    o.CreateMap<NotificationModel, EmailModel>();
    o.CreateMap<CallApp.Api.Model.MessageModel, CallApp.Domain.Respons.Models.Impementation.MessageModel>();
    o.CreateMap<CallApp.Domain.Respons.Models.Impementation.MessageModel, CallApp.Api.Model.MessageModel>();
}, AppDomain.CurrentDomain.GetAssemblies());

var key = builder.Configuration.GetValue<string>("WyFisher");

builder.Services.AddDbContext<AldagiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AldagiDatabase")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<ISendEmailService, SendEmailService>();
builder.Services.AddScoped<IWyFisherService, WyFisherService>();
builder.Services.AddSingleton(new WyFisherModel { Key = key });

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