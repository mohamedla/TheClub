using ClubContracts;
using ClubLoggerService;
using ClubModels;
using ClubRepository;
using Microsoft.EntityFrameworkCore;
using ClubAPI.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using ClubAPI.ActionFilter;
using ClubAPI;
using ClubAPI.ActionFilter.GeneralCodes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RepositoryContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("TheClub") ?? throw new InvalidOperationException("Can't Found Connection String"), b => b.MigrationsAssembly("ClubAPI") ));

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<ILoggerManager, LoggerManager>();
builder.Services.AddAutoMapper(typeof(Program));

//Validations
builder.Services.AddScoped<ModelStateValidationFilter>();
//Check Exist Validations
builder.Services.AddScoped<CityExistValidation>();
builder.Services.AddScoped<GenderExistValidation>();
builder.Services.AddScoped<JobExistValidation>();
builder.Services.AddScoped<MartialStatusExistValidation>();
builder.Services.AddScoped<MembershipExistValidation>();
builder.Services.AddScoped<NationalityExistValidation>();
builder.Services.AddScoped<QualificationExistValidation>();
builder.Services.AddScoped<ReferenceExistValidation>();
builder.Services.AddScoped<ReligionExistValidation>();
builder.Services.AddScoped<SectionExistValidation>();
builder.Services.AddScoped<TitleExistValidation>();
builder.Services.AddScoped<TransferExistValidation>();

builder.Services.AddScoped<MemberExistValidation>();

builder.Services.ConfigCORS();
builder.Services.ConfigIISIntegration();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts(); // Strict-Transport-Security header
}

app.UseHttpsRedirection(); // Enforce Https requests

app.ConfigExceptionHandler(new LoggerManager());

app.UseCors(ServiceExtensions.corsPolicy);

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
