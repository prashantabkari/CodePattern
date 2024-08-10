
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using EmployerApi.Data;


var builder = WebApplication.CreateBuilder(args);


// Configure the DbContext with a connection string
builder.Services.AddDbContext<EmployerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EMPLOYER_DB")));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employer API V1");
        c.RoutePrefix = string.Empty; // Set Swagger UI at the app's root
    });

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
