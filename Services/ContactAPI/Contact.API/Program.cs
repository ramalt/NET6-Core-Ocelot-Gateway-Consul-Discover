using Contact.API.RegisterExtensions;
using Contact.API.Settings;
using Contact.Infrastructure;
using Contact.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IContactService, ContactService>();

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

app.MapControllers();

app.RegisterConsul(serviceSettings); // Call RegisterConsul method with the loaded service settings

app.Run();