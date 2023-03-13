using FluentAssertions.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RedeSocialEventos.DAL.Data;
using System.Configuration;
using static RedeSocialEventos.DAL.Data.DesignTimeDbContextFactory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add services to the container.
builder.Services.AddControllersWithViews();

//DB Connection Instance
builder.Services.AddDbContext<RedeSocialContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RedeSocialContext")));

//Configurations for the Identity

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<RedeSocialContext>()
                 .AddDefaultTokenProviders();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Config for use de identity
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
