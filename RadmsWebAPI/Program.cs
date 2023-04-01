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
builder.Services.AddScoped<IAccidentSeverityLevelServicecs, AccidentSeverityLevelServicecs>();
builder.Services.AddScoped<IAccidentSeverityLevelRepository, AccidentSeverityLevelRepository>();
builder.Services.AddScoped<IHighWayTypeSerivice, HighWayTypeSerivice>();
builder.Services.AddScoped<IHighWayTypeRepository, HighWayTypeRepository>();
builder.Services.AddScoped<IHighwayMasterService, HighwayMasterService>();
builder.Services.AddScoped<IHighwayMasterRepository, HighwayMasterRepository>();
builder.Services.AddScoped<IpaymentType, PaymentTypeService>();
builder.Services.AddScoped<IPaymentTypeRepository, PaymentTypeRepository>();

builder.Services.AddScoped<IRoadCarriagewayTypeService, RoadCarriagewayTypeService>();
builder.Services.AddScoped<IRoadCarriagewayTypeRepository, RoadCarriagewayTypeRepository>();

builder.Services.AddScoped<IRoadSurfaceConditionService, RoadSurfaceConditionService>();
builder.Services.AddScoped<IRoadSurfaceConditionRepository, RoadSurfaceConditionRepository>();

builder.Services.AddScoped<ILandmarkTypeService, LandmarkTypeService>();
builder.Services.AddScoped<ILandmarkTypeRepository, LandmarkTypeRepository>();

builder.Services.AddScoped<IAirConditionTypeService, AirConditionTypeService>();
builder.Services.AddScoped<IAirConditionTypeRepository, AirConditionTypeRepository>();

//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IJunctionTypeService, JunctionTypeService>();
builder.Services.AddScoped<IJunctionTypeRepository, JunctionTypeRepository>();

builder.Services.AddScoped<IlightConditionService, lightConditionService>();
builder.Services.AddScoped<IlightConditionRepository, lightConditionRepository>();


builder.Services.AddScoped<ISpeedLimitService, SpeedLimitService>();
builder.Services.AddScoped<ISpeedLimitRepository, SpeedLimitRepository>();

builder.Services.AddScoped<IUserMasterService, UserMasterService>();
builder.Services.AddScoped<IUserMasterRepository, UserMasterRepository>();

builder.Services.AddScoped<ITerrainTypeService, TerrainTypeService>();
builder.Services.AddScoped<ITerrianTypeRepository, TerrianTypeRepository>();

builder.Services.AddScoped<IImpactTypeService, ImpactTypeService>();
builder.Services.AddScoped<IImpactTypeRepository, ImpactTypeRepository>();

builder.Services.AddScoped<ICollisionTypeLookupService, CollisionTypeService>();
builder.Services.AddScoped<ICollisionTypeRepository, CollisionTypeLookupRepository>();




builder.Services.AddCors(options =>
{
options.AddPolicy("CorsPolicy", builder =>
{
    builder
    .SetIsOriginAllowed(_ => true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .WithExposedHeaders("X-InlineCount");
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
    app.UseCors("CorsPolicy");
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
