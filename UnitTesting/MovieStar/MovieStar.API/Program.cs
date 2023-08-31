using Microsoft.EntityFrameworkCore;
using MovieStar.Core;
using MovieStar.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

// DB Context
builder.Services.AddDbContextFactory<CharacterContext>(options =>{
    options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
});

// Service Register

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



// app.UseHttpsRedirection();
app.MapControllers();

app.Run();

