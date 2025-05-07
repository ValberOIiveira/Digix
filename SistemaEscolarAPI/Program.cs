using Microsoft.EntityFrameworkCore;
using SistemaEscolarAPI.Models;
using SistemaEscolarAPI.DTO;
using SistemaEscolarAPI.Database;
using FluentValidation.AspNetCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));


builder.Services.AddControllers();
builder.Services.AddAuthorization();
builder.Services.AddSwaggerGen(c => 
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sistema Escolar API", Version = "v1" });
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {

        var secretKey = builder.Configuration["ConnectionStrings:TokenPassword"];
        options.TokenValidationParameters = new TokenValidationParameters {
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey)),
            ValidateIssuer = false,
            ValidateAudience = false

        };
    });

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();

app.MapGet("/", context =>
{
    context.Response.Redirect("/index.html");
    return Task.CompletedTask;
});

app.MapControllers();
app.Run();