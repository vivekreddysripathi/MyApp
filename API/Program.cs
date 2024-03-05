using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<DataContext>(u =>
u.UseSqlServer(builder.Configuration.GetConnectionString("AngularApp")));

var app = builder.Build();

app.UseHsts();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
