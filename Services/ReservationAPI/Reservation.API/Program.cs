using Contact.API.RegisterExtensions;
using Reservation.API.Settings;
using Reservation.Infrastructure;
using Reservation.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IReservationService, ReservationService>();

ServiceSettings serviceSettings = new ServiceSettings();

// Load settings from appsettings.json
builder.Configuration.GetSection("ServiceSettings").Bind(serviceSettings);

builder.Services.AddSingleton(serviceSettings);
builder.Services.AddConsulSettings(serviceSettings);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

// app.UseAuthorization();

app.RegisterConsul(serviceSettings);

app.MapControllers();

app.Run();
