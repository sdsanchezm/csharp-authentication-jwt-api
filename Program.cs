using AuthenticationAPI2.Data;
using AuthenticationAPI2.Extensions;
using AuthenticationAPI2.Interfaces;
using AuthenticationAPI2.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// these 2 methods Application and Identity, come from Extensions
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityService(builder.Configuration);

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// this method ask for a valid token
app.UseAuthentication();

// this method says, ok there's a valid token, then you are or not authorized
app.UseAuthorization();

// cors configuration to allow specific origins:
//app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));

// cors configuration to allow all origins:
app.UseCors(builder => builder.AllowAnyHeader()
    .AllowAnyMethod()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials() // allow credentials
    );

app.MapControllers();

app.Run();
