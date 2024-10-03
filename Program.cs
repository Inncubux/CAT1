using api.src.Data;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
Env.Load();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string connectionString = Environment.GetEnvironmentVariable("DATABASE_URL") ?? "Database Source =app.db";
builder.Services.AddDbContext<ApplicationDBcontext>(opt => opt.UseSqlite(connectionString));
var app = builder.Build();

using (var scope = app.Services.CreateScope()){
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDBcontext>();
    await context.Database.MigrateAsync();
    await Seeder.SeedAsync(context);
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
