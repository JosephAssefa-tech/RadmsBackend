using RadmsRepositoryFacade;
using RadmsRepositoryManager.Services;
using RadmsServiceFacade;
using RadmsServiceManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAccidentRepository, AccidentRepository>();
builder.Services.AddScoped<IAccidentService, AccidentService>();
builder.Services.AddScoped<IAccidentServiceCRUD, AccidentService>(); 
builder.Services.AddScoped<IAccidentDetailsTransactionRepository, AccidentDetailsTransactionRepository>();
builder.Services.AddScoped<IAccidentDetailsTransaction, AccidentDetailsTransactionService>();
builder.Services.AddScoped<IVehicleDetailsTransactionRepository, VehicleDetailsTransactionRepository>();
builder.Services.AddScoped<IVehicleDetailsTransaction, VehicleDetailsTransactionService>();
builder.Services.AddScoped<IVictimDetailTransactionRepository, VictimDetailTransactionRepository>();
builder.Services.AddScoped<IVictimDetailTransaction, VictimDetailTransactionService>();
builder.Services.AddScoped<ILegalMeasurementDetailsTransactionRepository, LegalMeasurementDetailsTransactionRepository>();
builder.Services.AddScoped<ILegalMeasurementDetailsTransaction, LegalMeasurementDetailsTransactionService>();
builder.Services.AddScoped<ILegalMeasurementDetailsTransactionRepository, LegalMeasurementDetailsTransactionRepository>();
builder.Services.AddScoped<IWeatherConditionType, WeatherConditionTypeService>();
builder.Services.AddScoped<IWeatherConditionTypeRepository, WeatherConditionTypeRepository>();
builder.Services.AddScoped<IRegionMaster, RegionMasterService>();
builder.Services.AddScoped<IRegionMasterRepository, RegionMasterRepository>();
builder.Services.AddScoped<IPoliceStationMaster, PoliceStationMasterService>();
builder.Services.AddScoped<IPoliceStationMasterRepository, PoliceStationMasterRepository>();
builder.Services.AddScoped<IZoneMasterService, ZoneMasterService>();
builder.Services.AddScoped<IZoneMasterRepository, ZoneMasterRepository>();
builder.Services.AddScoped<ICityMasterService, CityMasterService>();
builder.Services.AddScoped<ICityMasterRepository, CityMasterRepository>();
builder.Services.AddScoped<IWoredaMasterService, WoredaMasterService>();
builder.Services.AddScoped<IWoredaMasterRepository, WoredaMasterRepository>();
builder.Services.AddScoped<ISubCityMasterService, SubCityMasterService>();
builder.Services.AddScoped<ISubCityRepository, SubCityRepository>();
builder.Services.AddScoped<IAccidentType, AccidentTypeService>();
builder.Services.AddScoped<IAccidentTypeRepository, AccidentTypeRepository>();



//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());








builder.Services.AddCors(options =>
{
options.AddPolicy("AllowAll", builder =>
{
builder.AllowAnyOrigin()
       .AllowAnyHeader()
       .AllowAnyMethod();
});
});


{
    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseCors("AllowAll");
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
