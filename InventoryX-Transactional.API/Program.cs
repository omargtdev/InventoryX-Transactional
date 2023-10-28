using Microsoft.EntityFrameworkCore;
using InventoryX_Transactional.API.Extensions;
using InventoryX_Transactional.Data;

var builder = WebApplication.CreateBuilder(args);

string myAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options => 
{
    options.AddPolicy(name: myAllowSpecificOrigins,
        policy => 
        {
            policy.WithOrigins("http://localhost:5500") // dev
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// Add services to the container.
builder.Services.AddDbContext<InventoryXDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("InventoryxDb"));
});
builder.Services.AddRepositories();
builder.Services.AddServices();

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

app.UseCors(myAllowSpecificOrigins);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
