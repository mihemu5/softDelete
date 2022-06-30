using Microsoft.EntityFrameworkCore;
using SoftDelete;
using SoftDelete.Services;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<SoftDeleteContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("softDeleteDbConnection"));
    options.LogTo(a => Debug.WriteLine(a));
});
builder.Services.AddTransient<IStudentService, StudentService>();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
