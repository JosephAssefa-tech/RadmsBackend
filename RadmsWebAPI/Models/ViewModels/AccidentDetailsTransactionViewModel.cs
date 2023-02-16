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
        //public virtual HighwayMasterViewModel HidNavigation { get; set; } = null!;
        //public virtual HighwayTypeLookupViewModel HighwayType { get; set; } = null!;
        //public virtual ImpactTypeLookupViewModel ImpactType { get; set; } = null!;
        //public virtual JunctionTypeLookupViewModel JunctionType { get; set; } = null!;
        //public virtual LandmarkTypeLookupViewModel? LandmarkType { get; set; }
        //public virtual LightConditionLookupViewModel? LightCondtion { get; set; }
        //public virtual PavementTypeLookupViewModel PavementType { get; set; } = null!;
        //public virtual PoliceStationMasterViewModel Ps { get; set; } = null!;
        //public virtual RegionMasterViewModel? Region { get; set; }
        //public virtual RoadCarriagewayTypeLookupViewModel RoadCarriageway { get; set; } = null!;
        //public virtual RoadSurfaceConditionLookupViewModel RoadSurface { get; set; } = null!;
        //public virtual SeverityLevelLookupViewModel Severity { get; set; } = null!;
        //public virtual SpeedLimitLookupViewModel SpeedLimit { get; set; } = null!;
        //public virtual SubCityMasterViewModel? SubCity { get; set; }
        //public virtual TerrainTypeLookupViewModel TerrianType { get; set; } = null!;
        //public virtual UserMasterViewModel User { get; set; } = null!;
        //public virtual WeatherConditionTypeLookupViewModel WeatherCond { get; set; } = null!;
        //public virtual WoredaMasterViewModel? Woreda { get; set; }
        //public virtual ZoneMasterViewModel? Zone { get; set; }
        //public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
        // public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
        public AccidentDetailsTransactionViewModel()
        {

        }
        public AccidentDetailsTransactionViewModel(AccidentDetailsTransactionEntity entity)
        {
            Lat = entity.Lat;
            Long = entity.Long;
            AccidentId = entity.AccidentId;
            AccidentLocalName = entity.AccidentLocalName;
            DateAndTime = entity.DateAndTime;
            Psid = entity.Psid;
            KebeleName = entity.KebeleName;
            Piname = entity.KebeleName;
            PoliceRecordNumber = entity.PoliceRecordNumber;
            NumberOfVehicles = entity.NumberOfVehicles;
            PropertyDamage = entity.PropertyDamage;
            NumberofVictims = entity.NumberofVictims;
            Video1 = entity.Video1;
            Video2 = entity.Video2;
            Video3 = entity.Video3;
            Video4 = entity.Video4;
            Image1 = entity.Image1;
            Image2 = entity.Image2;
            Image3 = entity.Image3;
            Image4 = entity.Image4;
            Image5 = entity.Image5;
            Image6 = entity.Image6;
            SubmissionFlag = entity.SubmissionFlag;
            Hid = entity.Hid;
            AccidentLocalName = entity.AccidentLocalName;
            AccidentType = new AccidentTypeLookupViewModel(entity.AccidentType);
            AirCondition = new AirConditionTypeLookupViewModel(entity.AirCondition);
            // this.AccidentType = new AccidentTypeLookupEntity(model.AccidentType);
            //this.AccidentType = new AccidentTypeLookupEntity(model.AccidentType);
        }

        public T MapToViewEntity<T>() where T : class
        {
            AccidentDetailsTransactionEntity entity = new AccidentDetailsTransactionEntity();
            entity.Lat = Lat;
            entity.Long = Long;
            entity.AccidentId = AccidentId;
            entity.AccidentLocalName = AccidentLocalName;
            entity.DateAndTime = DateAndTime;
            entity.Psid = Psid;
            entity.KebeleName = KebeleName;
            entity.KebeleName = Piname;
            entity.PoliceRecordNumber = PoliceRecordNumber;
            entity.NumberOfVehicles = NumberOfVehicles;
            entity.PropertyDamage = PropertyDamage;
            entity.NumberofVictims = NumberofVictims;
            entity.Video1 = Video1;
            entity.Video2 = Video2;
            entity.Video3 = Video3;
            entity.Video4 = Video4;
            entity.Image1 = Image1;
            entity.Image2 = Image2;
            entity.Image3 = Image3;
            entity.Image4 = Image4;
            entity.Image5 = Image5;
            entity.Image6 = Image6;
            entity.SubmissionFlag = SubmissionFlag;
            entity.Hid = Hid;
            entity.AccidentLocalName = AccidentLocalName;
            // entity.AccidentType = this.AccidentType.<AccidentTypeLookupEntity>();
            return entity as T;


        }
    }
}

