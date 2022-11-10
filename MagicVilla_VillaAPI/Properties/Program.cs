//using Serilog;


using MagicVilla_VillaAPI.Logging;

var builder = WebApplication.CreateBuilder(args); //Logging

// Add services to the container.

//Stop the default logger for customizing Logger (dependency injection)
//Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
//    .WriteTo.File("log/villaLogs.txt", rollingInterval:RollingInterval.Day).CreateLogger(); //generating log file every day
//builder.Host.UseSerilog();

builder.Services.AddControllers(option => {
    //option.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters(); //return type:json,xml
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ILogging, LoggingV2>();
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

