using RadmsEntities;
using RadmsWebAPI.ViewModels.BaseModel;

namespace RadmsWebAPI.Models.ViewModels
{
    public class AccidentDetailsTransactionViewModel: ViewBaseModel
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
        public virtual AccidentTypeLookupViewModel AccidentType { get; set; } = null!;
        public virtual AirConditionTypeLookupViewModel AirCondition { get; set; } = null!;
        public virtual AccidentCauseLookupViewModel CauseofAccident { get; set; } = null!;
        public virtual CityMasterViewModel? City { get; set; }
        public virtual CollisionTypeLookupViewModel CollisionType { get; set; } = null!;
        public virtual HighwayMasterViewModel HidNavigation { get; set; } = null!;
        public virtual HighwayTypeLookupViewModel HighwayType { get; set; } = null!;
        public virtual ImpactTypeLookupViewModel ImpactType { get; set; } = null!;
        public virtual JunctionTypeLookupViewModel JunctionType { get; set; } = null!;
        public virtual LandmarkTypeLookupViewModel? LandmarkType { get; set; }
        public virtual LightConditionLookupViewModel? LightCondtion { get; set; }
        public virtual PavementTypeLookupViewModel PavementType { get; set; } = null!;
        public virtual PoliceStationMasterViewModel Ps { get; set; } = null!;
        public virtual RegionMasterViewModel? Region { get; set; }
        public virtual RoadCarriagewayTypeLookupViewModel RoadCarriageway { get; set; } = null!;
        public virtual RoadSurfaceConditionLookupViewModel RoadSurface { get; set; } = null!;
        public virtual SeverityLevelLookupViewModel Severity { get; set; } = null!;
        public virtual SpeedLimitLookupViewModel SpeedLimit { get; set; } = null!;
        public virtual SubCityMasterViewModel? SubCity { get; set; }
        public virtual TerrainTypeLookupViewModel TerrianType { get; set; } = null!;
        public virtual UserMasterViewModel User { get; set; } = null!;
        public virtual WeatherConditionTypeLookupViewModel WeatherCond { get; set; } = null!;
        public virtual WoredaMasterViewModel? Woreda { get; set; }
        public virtual ZoneMasterViewModel? Zone { get; set; }
        //public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
        // public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
        public AccidentDetailsTransactionViewModel()
        {

        }
        public AccidentDetailsTransactionViewModel(AccidentDetailsTransactionEntity entity)
        {
            this.Lat = entity.Lat;
            this.Long = entity.Long;
            this.AccidentId = (decimal)entity.AccidentId;
            this.AccidentLocalName = entity.AccidentLocalName;
            this.DateAndTime = entity.DateAndTime;
            this.Psid = entity.Psid;
            this.KebeleName = entity.KebeleName;
            this.Piname = entity.Piname;
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
            //this.AccidentType = new AccidentTypeLookupViewModel(entity.AccidentType);
            //this.AirCondition = new AirConditionTypeLookupViewModel(entity.AirCondition);
            //this.CauseofAccident =new AccidentCauseLookupViewModel(entity.CauseofAccident);
            //this.City =new CityMasterViewModel(entity.City);
            //this.CollisionType = new CollisionTypeLookupViewModel(entity.CollisionType);
            //this.HidNavigation=new HighwayMasterViewModel(entity.HidNavigation);
            //this.HighwayType = new HighwayTypeLookupViewModel(entity.HighwayType);
            //this.ImpactType = new ImpactTypeLookupViewModel(entity.ImpactType);
            //this.JunctionType = new JunctionTypeLookupViewModel(entity.JunctionType);
            //this.LandmarkType = new LandmarkTypeLookupViewModel(entity.LandmarkType);
            //this.LightCondtion = new LightConditionLookupViewModel(entity.LightCondtion);
            //this.PavementType = new PavementTypeLookupViewModel(entity.PavementType);
            //this.Ps = new PoliceStationMasterViewModel(entity.Ps);
            //this.Region = new RegionMasterViewModel(entity.Region);
            //this.RoadCarriageway = new RoadCarriagewayTypeLookupViewModel(entity.RoadCarriageway);
            //this.RoadSurface = new RoadSurfaceConditionLookupViewModel(entity.RoadSurface);
            //this.Severity = new SeverityLevelLookupViewModel(entity.Severity);
            //this.SpeedLimit = new SpeedLimitLookupViewModel(entity.SpeedLimit);
            //this.SubCity = new SubCityMasterViewModel(entity.SubCity);
            //this.TerrianType = new TerrainTypeLookupViewModel(entity.TerrianType);
            //this.User = new UserMasterViewModel(entity.User);
            //this.WeatherCond = new WeatherConditionTypeLookupViewModel(entity.WeatherCond);
            //this.Woreda = new WoredaMasterViewModel(entity.Woreda);
            //this.Zone = new ZoneMasterViewModel(entity.Zone);




            //this.AccidentType = new AccidentTypeLookupEntity(model.AccidentType);
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
            entity.Piname = this.Piname;
            entity.KebeleName = this.KebeleName;
            entity.KebeleName = this.Piname;
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
            entity.AccidentLocalName = this.AccidentLocalName;
            // entity.AccidentType = this.AccidentType.<AccidentTypeLookupEntity>();
            return entity as T;


        }
    }
}

