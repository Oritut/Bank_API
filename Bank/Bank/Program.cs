using Pagi.Core.Repositories;
using Pagi.Core.Service;
using Pagi.Data;
using Pagi.Data.Repositories;
using Pagi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClerkService, ClerkService>();
builder.Services.AddScoped<IClerkRepositories, ClerkRepositories>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IClientRepositories, ClientRepositories>();
builder.Services.AddScoped<ITurnService, TurnService>();
builder.Services.AddScoped<ITurnRepositories, TurnRepositories>();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddDbContext<DataContext>();
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
