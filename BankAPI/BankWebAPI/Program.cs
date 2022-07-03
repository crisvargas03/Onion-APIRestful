using Application;
using Persistence;
using Shared;
using TrekkoBankAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplicationLayer();
builder.Services.AddApiVersioningExtension();

// In the builder we have some of the method and configs of the startup.cs.
builder.Services.AddPersistenceInfraestructure(builder.Configuration);
builder.Services.AddSharedInfraestructure(builder.Configuration);

var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseErrorHandlingMidllerware();
app.UseAuthorization();
app.MapControllers();
app.Run();
