using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Application.Mappings;
using SwiftBlog.Api.Persistance.Context;
using SwiftBlog.Api.Persistance.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(opt =>
{
    opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SwiftAppContext>(opt =>
{
    opt.UseSqlServer("Server=.\\SQLEXPRESS;Database=SwiftAppApiDb;Trusted_Connection=True;TrustServerCertificate=True");
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddAutoMapper(opt =>
{
    opt.AddProfiles(new List<Profile>()
    {
        new BlogProfile(),
        new CategoryProfile(),
        new UserProfile()
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
