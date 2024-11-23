using Microsoft.EntityFrameworkCore;
using Data;
using Api.Services;
using Api.Repositories;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TFOMSContext>(options =>
    options.UseSqlServer( builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<ISpiskiNaDnFromMoRepository, SpiskiNaDNFromMORepository>();
builder.Services.AddScoped<ISpiskiNaDNFromMOService, SpiskiNaDnFromMoService>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();