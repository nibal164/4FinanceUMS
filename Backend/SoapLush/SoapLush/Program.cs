using Microsoft.EntityFrameworkCore;
using SoapLush.Data;
using SoapLush.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Injection
builder.Services.AddDbContext<SoapLushDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SoapLush"));
});

builder.Services.AddScoped<IProductsRepository, ProductRepository>();
builder.Services.AddScoped<ISoapCategoryRepository, SoapCategoryRepository>();
builder.Services.AddScoped<ISoapSubCategoryRepository, SoapSubCategoryRepository>();


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
