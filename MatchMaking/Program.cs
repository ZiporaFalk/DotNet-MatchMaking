using Matchmaking.Api;
using Matchmaking.Core;
//using Matchmaking.Api.Interfaces;
using Matchmaking.Core.Repositories;
using Matchmaking.Core.Services;
using Matchmaking.Data;
using Matchmaking.Data.Repositories;// לבדוק אם נכון לגבי DataContext
using Matchmaking.Service.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddSingleton<IDataContext, DataContext>();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IResumeService, ResumeService>();
builder.Services.AddScoped<IResumeRepository, ResumeRepository>();
builder.Services.AddScoped<IMeetingService, MeetingService>();
builder.Services.AddScoped<IMeetingRepository, MeetingRepository>();
builder.Services.AddScoped<IMatchMakerService, MatchMakerService>();
builder.Services.AddScoped<IMatchMakerRepository, MatchMakerRepository>();
builder.Services.AddScoped<IMatchService, MatchService>();
builder.Services.AddScoped<IMatchRepository, MatchRepository>();
builder.Services.AddScoped<IManagerRepository, ManagerRepository>();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("mypolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
