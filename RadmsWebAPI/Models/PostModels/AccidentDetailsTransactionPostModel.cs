using RadmsDataModels.Models;
using RadmsEntities;
using RadmsWebAPI.Models.ViewModels;
using RadmsWebAPI.ViewModels.BaseModel;

namespace RadmsWebAPI.Models.PostModels
{
    public class AccidentDetailsTransactionPostModel : ViewBaseModel
    {
        public double Lat { get; set; }
        public double Long { get; set; }
        public decimal AccidentId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Psid { get; set; } = null!;
        public string? KebeleName { get; set; }
        public string Piname { get; set; } = null!;
        public string PoliceRecordNumber { get; set; } = null!;
        public int NumberOfVehicles { get; set; }
        public int PropertyDamage { get; set; }
        public int NumberofVictims { get; set; }
        public string? Video1 { get; set; }
        public string? Video2 { get; set; }
        public string? Video3 { get; set; }
        public string? Video4 { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public string? Image5 { get; set; }
        public string? Image6 { get; set; }
        public int SubmissionFlag { get; set; }
        public string Hid { get; set; } = null!;
        public string? AccidentLocalName { get; set; }
        public virtual AccidentTypeLookupPostModel AccidentType { get; set; } = null!;
        public virtual AirConditionTypeLookupPostModel AirCondition { get; set; } = null!;
        public virtual AccidentCauseLookupPostModel CauseofAccident { get; set; } = null!;
        public virtual CityMasterPostModel? City { get; set; }
        public virtual CollisionTypeLookupPostModel CollisionType { get; set; } = null!;
        public virtual HighwayMasterPostModel HidNavigation { get; set; } = null!;
        public virtual HighwayTypeLookupPostModel HighwayType { get; set; } = null!;
        public virtual ImpactTypeLookupPostModel ImpactType { get; set; } = null!;
        public virtual JunctionTypeLookupPostModel JunctionType { get; set; } = null!;
        public virtual LandmarkTypeLookupPostModel? LandmarkType { get; set; }
        public virtual LightConditionLookupPostModel? LightCondtion { get; set; }
        public virtual PavementTypeLookupPostModel PavementType { get; set; } = null!;
        public virtual PoliceStationMasterPostModel Ps { get; set; } = null!;
        public virtual RegionMasterPostModel? Region { get; set; }
        public virtual RoadCarriagewayTypeLookupPostModel RoadCarriageway { get; set; } = null!;
        public virtual RoadSurfaceConditionLookupPostModel RoadSurface { get; set; } = null!;
        public virtual SeverityLevelLookupPostModel Severity { get; set; } = null!;
        public virtual SpeedLimitLookupPostModel SpeedLimit { get; set; } = null!;
        public virtual SubCityMasterPostModel? SubCity { get; set; }
        public virtual TerrainTypeLookupPostModel TerrianType { get; set; } = null!;
        public virtual UserMasterPostModel User { get; set; } = null!;
        public virtual WeatherConditionTypeLookupPostModel WeatherCond { get; set; } = null!;
        public virtual WoredaMasterPostModel? Woreda { get; set; }
        public virtual ZoneMasterPostModel? Zone { get; set; }
        //public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
        // public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
        public AccidentDetailsTransactionPostModel()
        {

        }
        public AccidentDetailsTransactionPostModel(AccidentDetailsTransactionEntity entity)
        {
            this.Lat = entity.Lat;
            this.Long = entity.Long;
            this.AccidentId = (decimal)entity.AccidentId;
            this.AccidentLocalName = entity.AccidentLocalName;
            this.DateAndTime = entity.DateAndTime;
            this.Psid = entity.Psid;
            this.KebeleName = entity.KebeleName;
            Piname = entity.KebeleName;
            this.PoliceRecordNumber = entity.PoliceRecordNumber;
            this.NumberOfVehicles = entity.NumberOfVehicles;
            this.PropertyDamage = entity.PropertyDamage;
            this.NumberofVictims = entity.NumberofVictims;
            this.Video1 = entity.Video1;
            this.Video2 = entity.Video2;
            this.Video3 = entity.Video3;
            this.Video4 = entity.Video4;
            this.Image1 = entity.Image1;
            this.Image2 = entity.Image2;
            this.Image3 = entity.Image3;
            this.Image4 = entity.Image4;
            this.Image5 = entity.Image5;
            this.Image6 = entity.Image6;
            this.SubmissionFlag = entity.SubmissionFlag;
            this.Hid = entity.Hid;
            this.AccidentLocalName = entity.AccidentLocalName;
            this.LandmarkType = new LandmarkTypeLookupPostModel(entity.LandmarkType);
            this.AccidentType = new AccidentTypeLookupPostModel(entity.AccidentType);
            this.AirCondition = new AirConditionTypeLookupPostModel(entity.AirCondition);
            this.City = new CityMasterPostModel(entity.City);
            this.Region = new RegionMasterPostModel(entity.Region);
            this.Woreda = new WoredaMasterPostModel(entity.Woreda);
            this.Zone = new ZoneMasterPostModel(entity.Zone);
            this.CollisionType = new CollisionTypeLookupPostModel(entity.CollisionType);
            this.HidNavigation = new HighwayMasterPostModel(entity.HidNavigation);
            this.HighwayType = new HighwayTypeLookupPostModel(entity.HighwayType);
            this.ImpactType =new ImpactTypeLookupPostModel(entity.ImpactType);
            this.JunctionType =new JunctionTypeLookupPostModel(entity.JunctionType);
            this.LightCondtion =new LightConditionLookupPostModel(entity.LightCondtion);
            this.SubCity =new SubCityMasterPostModel(entity.SubCity);
            this.WeatherCond = new WeatherConditionTypeLookupPostModel(entity.WeatherCond);
            this.User = new UserMasterPostModel(entity.User);
            this.TerrianType = new TerrainTypeLookupPostModel(entity.TerrianType);
            this.SpeedLimit =new SpeedLimitLookupPostModel(entity.SpeedLimit);
            this.Severity = new SeverityLevelLookupPostModel(entity.Severity);
            this.RoadCarriageway = new RoadCarriagewayTypeLookupPostModel(entity.RoadCarriageway);
            this.RoadSurface = new RoadSurfaceConditionLookupPostModel(entity.RoadSurface);

        }

        public T MapToViewEntity<T>() where T : class
        {
            AccidentDetailsTransactionEntity entity = new AccidentDetailsTransactionEntity();
            entity.Lat = this.Lat;
            entity.Long = this.Long;
            entity.AccidentId = this.AccidentId;
            entity.AccidentLocalName = this.AccidentLocalName;
            entity.DateAndTime = this.DateAndTime;
            entity.Psid = this.Psid;
            entity.KebeleName = this.KebeleName;
            entity.Piname = this.Piname;
            entity.PoliceRecordNumber = this.PoliceRecordNumber;
            entity.NumberOfVehicles = this.NumberOfVehicles;
            entity.PropertyDamage = this.PropertyDamage;
            entity.NumberofVictims = this.NumberofVictims;
            entity.Video1 = this.Video1;
            entity.Video2 = this.Video2;
            entity.Video3 = this.Video3;
            entity.Video4 = this.Video4;
            entity.Image1 = this.Image1;
            entity.Image2 = this.Image2;
            entity.Image3 = this.Image3;
            entity.Image4 = this.Image4;
            entity.Image5 = this.Image5;
            entity.Image6 = this.Image6;
            entity.SubmissionFlag = this.SubmissionFlag;
            entity.Hid = this.Hid;
            entity.AccidentType = this.AccidentType.MapToViewEntity<AccidentTypeLookupEntity>();
            entity.AirCondition = this.AirCondition.MapToViewEntity<AirConditionTypeLookupEntity>();
            entity.CauseofAccident = this.CauseofAccident.MapToViewEntity<AccidentCauseLookupEntity>();
            entity.AirCondition = this.AirCondition.MapToViewEntity<AirConditionTypeLookupEntity>();
            entity.City = this.City.MapToViewEntity<CityMasterEntity>();
            entity.Region = this.Region.MapToViewEntity<RegionMasterEntity>();
            entity.Woreda = this.Woreda.MapToViewEntity<WoredaMasterEntity>();
            entity.Zone = this.Zone.MapToViewEntity<ZoneMasterEntity>();
            entity.PavementType=this.PavementType.MapToViewEntity<PavementTypeLookupEntity>();
            entity.LandmarkType = this.LandmarkType.MapToViewEntity<LandmarkTypeLookupEntity>();
            entity.TerrianType = this.TerrianType.MapToViewEntity<TerrainTypeLookupEntity>();
            entity.CollisionType = this.CollisionType.MapToViewEntity<CollisionTypeLookupEntity>();
            entity.HidNavigation = this.HidNavigation.MapToViewEntity<HighwayMasterEntity>();
            entity.HighwayType = this.HighwayType.MapToViewEntity<HighwayTypeLookupEntity>();
            entity.ImpactType = this.ImpactType.MapToViewEntity<ImpactTypeLookupEntity>();
            entity.JunctionType = this.JunctionType.MapToViewEntity<JunctionTypeLookupEntity>();
            entity.LightCondtion = this.LightCondtion.MapToViewEntity<LightConditionLookupEntity>();
            entity.SubCity = this.SubCity.MapToViewEntity<SubCityMasterEntity>();
            entity.WeatherCond = this.WeatherCond.MapToViewEntity<WeatherConditionTypeLookupEntity>();
            entity.User = this.User.MapToViewEntity<UserMasterEntity>();
            entity.SpeedLimit = this.SpeedLimit.MapToViewEntity<SpeedLimitLookupEntity>();
            entity.Severity = this.Severity.MapToViewEntity<SeverityLevelLookupEntity>();
            entity.Zone= this.Zone.MapToViewEntity<ZoneMasterEntity>();
            entity.RoadCarriageway = this.RoadCarriageway.MapToViewEntity<RoadCarriagewayTypeLookupEntity>();
            entity.RoadSurface = this.RoadSurface.MapToViewEntity<RoadSurfaceConditionLookupEntity>();
            return entity as T;


        }
    }
}
