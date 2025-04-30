using Microsoft.EntityFrameworkCore;
using SistemaEscolarAPI.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers().AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    });
    
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


    

 
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.Use(async (context, next) =>
{
    Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");
    await next.Invoke();
});

app.MapControllers();
app.Run();
