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
        //public virtual CityMaster? City { get; set; }
        //public virtual CollisionTypeLookup CollisionType { get; set; } = null!;
        //public virtual HighwayMaster HidNavigation { get; set; } = null!;
        //public virtual HighwayTypeLookup HighwayType { get; set; } = null!;
        //public virtual ImpactTypeLookup ImpactType { get; set; } = null!;
        //public virtual JunctionTypeLookup JunctionType { get; set; } = null!;
        //public virtual LandmarkTypeLookup? LandmarkType { get; set; }
        //public virtual LightConditionLookup? LightCondtion { get; set; }
        //public virtual PavementTypeLookup PavementType { get; set; } = null!;
        //public virtual PoliceStationMaster Ps { get; set; } = null!;
        //public virtual RegionMaster? Region { get; set; }
        //public virtual RoadCarriagewayTypeLookup RoadCarriageway { get; set; } = null!;
        //public virtual RoadSurfaceConditionLookup RoadSurface { get; set; } = null!;
        //public virtual SeverityLevelLookup Severity { get; set; } = null!;
        //public virtual SpeedLimitLookup SpeedLimit { get; set; } = null!;
        //public virtual SubCityMaster? SubCity { get; set; }
        //public virtual TerrainTypeLookup TerrianType { get; set; } = null!;
        //public virtual UserMaster User { get; set; } = null!;
        //public virtual WeatherConditionTypeLookup WeatherCond { get; set; } = null!;
        //public virtual WoredaMaster? Woreda { get; set; }
        //public virtual ZoneMaster? Zone { get; set; }
        //public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
        // public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
        public AccidentDetailsTransactionPostModel()
        {

        }
        public AccidentDetailsTransactionPostModel(AccidentDetailsTransactionEntity entity)
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
            AccidentType = new AccidentTypeLookupPostModel(entity.AccidentType);
            AirCondition = new AirConditionTypeLookupPostModel(entity.AirCondition);
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
            entity.AccidentType = this.AccidentType.MapToViewEntity<AccidentTypeLookupEntity>();
            entity.AirCondition = this.AirCondition.MapToViewEntity<AirConditionTypeLookupEntity>();
            return entity as T;


        }
    }
}
