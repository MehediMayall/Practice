using DishesAPI.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<DishesDbContext>(options => {
    options.UseSqlite(builder.Configuration["ConnectionStrings:local"]);
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// app.UseHttpsRedirection();



app.MapGet("/dishes",async (DishesDbContext db) =>{
    return await db.Dishes.ToListAsync();
});

app.MapGet("/dishes/{dishId:guid}", async (Guid dishId, DishesDbContext db) => {
    return await db.Dishes.FirstOrDefaultAsync(d=> d.Id == dishId);
});

app.MapGet("/dishes/{dishname}", async (string dishname, DishesDbContext db) => {
    return await db.Dishes.FirstOrDefaultAsync(d=> d.Name == dishname);
});

// Recreate & migrate the database on each run
// using (var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope()){
//     var context = serviceScope.ServiceProvider.GetRequiredService<DishesDbContext>();
//     context.Database.EnsureDeleted();
//     context.Database.Migrate();
// }


app.Run();

