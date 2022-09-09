using AutoMapper;
using Maqta.GateWay.EmployeeCRUD.Application;
using Maqta.GateWay.EmployeeCRUD.ApplicationContract;
using Maqta.GateWay.EmployeeCRUD.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureRepositoryWrapper();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddAutoMapper(typeof(Program));

// Auto Mapper Configurations
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new EmployeeProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}





//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();
