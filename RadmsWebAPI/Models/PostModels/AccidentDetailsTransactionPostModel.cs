using RadmsDataModels.Models;
using RadmsEntities;
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
        public virtual AccidentTypeLookup AccidentType { get; set; } = null!;
        //public virtual AirConditionTypeLookup AirCondition { get; set; } = null!;
        //public virtual AccidentCauseLookup CauseofAccident { get; set; } = null!;
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
            DateAndTime=entity.DateAndTime;
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
        }

        public T MapToViewEntity<T>() where T : class
        {
            AccidentDetailsTransactionEntity entity = new AccidentDetailsTransactionEntity();
            entity.Lat = Lat;
            entity.Long = Long;
            entity.AccidentId = AccidentId;
            entity.AccidentLocalName= AccidentLocalName ;
            entity.DateAndTime = DateAndTime ;
            entity.Psid = Psid ;
            entity.KebeleName = KebeleName ;
            entity.KebeleName = Piname  ;
            entity.PoliceRecordNumber = PoliceRecordNumber ;
            entity.NumberOfVehicles = NumberOfVehicles ;
            entity.PropertyDamage = PropertyDamage ;
            entity.NumberofVictims = NumberofVictims ;
            entity.Video1 = Video1 ;
            entity.Video2 = Video2  ;
            entity.Video3 = Video3 ;
            entity.Video4 = Video4 ;
            entity.Image1 = Image1  ;
            entity.Image2 = Image2 ;
            entity.Image3 = Image3 ;
            entity.Image4 = Image4  ;
            entity.Image5 = Image5   ;
            entity.Image6 = Image6 ;
            entity.SubmissionFlag = SubmissionFlag ;
            entity.Hid = Hid ;
            entity.AccidentLocalName = AccidentLocalName ;
           // entity.AccidentType = this.AccidentType.MapToEntity<TrainingEntity>();
            return entity as T;


        }
    }
}
