using RadmsDataAccessLogic;
using RadmsDataModels.Models;
using RadmsEntities.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class AccidentDetailsTransactionEntity:RadmsBaseEntity
    {
        RadmsContext context = new RadmsContext();

        public AccidentDetailsTransactionEntity()
        {
            //VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
            //VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }
        public double Lat { get; set; }
        public double Long { get; set; }

        public decimal AccidentId { get; set; }

        public DateTime DateAndTime { get; set; }
        // what is the below Psid
        public string Psid { get; set; } = null!;

        public string? KebeleName { get; set; }
  
        public int UserId { get; set; }

        public string Piname { get; set; } = null!;

        public string PoliceRecordNumber { get; set; } = null!;

        public int HighwayTypeId { get; set; }

        public int RoadCarriagewayId { get; set; }

        public int SpeedLimitId { get; set; }

        public int? LandmarkTypeId { get; set; }

        public int PavementTypeId { get; set; }

        public int TerrianTypeId { get; set; }

        public int RoadSurfaceId { get; set; }

        public int ImpactTypeId { get; set; }

        public int JunctionTypeId { get; set; }

        public int CollisionTypeId { get; set; }

        public int WeatherCondId { get; set; }

        public int SeverityId { get; set; }
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

        public int CauseofAccidentId { get; set; }

        public int? LightCondtionId { get; set; }

        public string Hid { get; set; } = null!;

        public int AirConditionId { get; set; }

        public int AccidentTypeId { get; set; }

        public int? WoredaId { get; set; }

        public int? SubCityId { get; set; }

        public int? CityId { get; set; }

        public int? RegionId { get; set; }

        public int? ZoneId { get; set; }

        public string? AccidentLocalName { get; set; }

        //public virtual AccidentTypeLookupEntity AccidentType { get; set; } = null!;

        //public virtual AirConditionTypeLookupEntity AirCondition { get; set; } = null!;

        //public virtual AccidentCauseLookupEntity CauseofAccident { get; set; } = null!;

        //public virtual CityMasterEntity? City { get; set; }

        //public virtual CollisionTypeLookupEntity CollisionType { get; set; } = null!;

        //public virtual HighwayMasterEntity HidNavigation { get; set; } = null!;

        //public virtual HighwayTypeLookupEntity HighwayType { get; set; } = null!;
  
        //public virtual ImpactTypeLookupEntity ImpactType { get; set; } = null!;

        //public virtual JunctionTypeLookupEntity JunctionType { get; set; } = null!;

        //public virtual LandmarkTypeLookupEntity? LandmarkType { get; set; }

        //public virtual LightConditionLookupEntity? LightCondtion { get; set; }

        //public virtual PavementTypeLookupEntity PavementType { get; set; } = null!;

        //public virtual PoliceStationMasterEntity Ps { get; set; } = null!;

        //public virtual RegionMasterEntity? Region { get; set; }

        //public virtual RoadCarriagewayTypeLookupEntity RoadCarriageway { get; set; } = null!;

        //public virtual RoadSurfaceConditionLookupEntity RoadSurface { get; set; } = null!;

        //public virtual SeverityLevelLookupEntity Severity { get; set; } = null!;

        //public virtual SpeedLimitLookupEntity SpeedLimit { get; set; } = null!;

        //public virtual SubCityMasterEntity? SubCity { get; set; }

        //public virtual TerrainTypeLookupEntity TerrianType { get; set; } = null!;

        //public virtual UserMasterEntity User { get; set; } = null!;

        //public virtual WeatherConditionTypeLookupEntity WeatherCond { get; set; } = null!;

        //public virtual WoredaMasterEntity? Woreda { get; set; }

        //public virtual ZoneMasterEntity? Zone { get; set; }

       // public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

       // public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }



        public AccidentDetailsTransactionEntity(AccidentDetailsTransaction model)
        {
            this.Lat = model.Lat;
            this.Long = model.Long;

            this.AccidentId = model.AccidentId;

            this.DateAndTime = model.DateAndTime;
            // what is the below Psid
            this.Psid = model.Psid;

            this.KebeleName = model.KebeleName;

            this.UserId = model.UserId;

            this.Piname = model.Piname;

            this.PoliceRecordNumber = model.PoliceRecordNumber;

            this.HighwayTypeId = model.HighwayTypeId;

            this.RoadCarriagewayId = model.RoadCarriagewayId;

            this.SpeedLimitId = model.SpeedLimitId;

            this.LandmarkTypeId = model.LandmarkTypeId;

            this.PavementTypeId = model.PavementTypeId;

            this.TerrianTypeId = model.TerrianTypeId;

            this.RoadSurfaceId = model.RoadSurfaceId;

            this.ImpactTypeId = model.ImpactTypeId;

            this.JunctionTypeId = model.JunctionTypeId;

            this.CollisionTypeId = model.CollisionTypeId;

            this.WeatherCondId = model.WeatherCondId;

            this.SeverityId = model.SeverityId;
            this.NumberOfVehicles = model.NumberOfVehicles;
            this.PropertyDamage = model.PropertyDamage;
            this.NumberofVictims = model.NumberofVictims;

            this.Video1 = model.Video1;

            this.Video2 = model.Video2;

            this.Video3 = model.Video3;

            this.Video4 = model.Video4;

            this.Image1 = model.Image1;

            this.Image2 = model.Image2;

            this.Image3 = model.Image3;

            this.Image4 = model.Image4;

            this.Image5 = model.Image5;

            this.Image6 = model.Image6;
            this.SubmissionFlag = model.SubmissionFlag;

            this.CauseofAccidentId = model.CauseofAccidentId;

            this.LightCondtionId = model.LightCondtionId;

            this.Hid = model.Hid;

            this.AirConditionId = model.AirConditionId;

            this.AccidentTypeId = model.AccidentTypeId;

            this.WoredaId = model.WoredaId;

            this.SubCityId = model.SubCityId;

            this.CityId = model.CityId; 

            this.RegionId = model.RegionId;

            this.ZoneId = model.ZoneId;

            this.AccidentLocalName = model.AccidentLocalName;

        //this.AccidentType = new AccidentTypeLookupEntity(model.AccidentType);
        //this.AirCondition = new AirConditionTypeLookupEntity(model.AirCondition);
        //this.CauseofAccident = new AccidentCauseLookupEntity(model.CauseofAccident);
        //this.City = new CityMasterEntity(model.City);
        //this.CollisionType = new CollisionTypeLookupEntity(model.CollisionType);
        //this.HidNavigation = new HighwayMasterEntity(model.HidNavigation);
        //this.HighwayType = new HighwayTypeLookupEntity(model.HighwayType);
        //this.ImpactType = new ImpactTypeLookupEntity(model.ImpactType);
        //this.JunctionType = new JunctionTypeLookupEntity(model.JunctionType);
        //this.LandmarkType = new LandmarkTypeLookupEntity(model.LandmarkType);
        //this.LightCondtion = new LightConditionLookupEntity(model.LightCondtion);
        //this.PavementType = new PavementTypeLookupEntity(model.PavementType);
        //this.Ps = new PoliceStationMasterEntity(model.Ps);
        //this.Region = new RegionMasterEntity(model.Region);
        //this.RoadCarriageway = new RoadCarriagewayTypeLookupEntity(model.RoadCarriageway);
        //this.RoadSurface = new RoadSurfaceConditionLookupEntity(model.RoadSurface);
        //this.Severity = new SeverityLevelLookupEntity(model.Severity);
        //this.SpeedLimit = new SpeedLimitLookupEntity(model.SpeedLimit);
        //this.SubCity = new SubCityMasterEntity(model.SubCity);
        //this.TerrianType = new TerrainTypeLookupEntity(model.TerrianType);
        //this.User = new UserMasterEntity(model.User);
        //this.WeatherCond = new WeatherConditionTypeLookupEntity(model.WeatherCond);
        //this.Woreda = new WoredaMasterEntity(model.Woreda);
        //this.Zone = new ZoneMasterEntity(model.Zone);




    }

        public T MapToModel<T>() where T : class
        {
            var now = DateTime.Now;
            var prefix = now.ToString("yyyyMMddHHmmss");
            var lastNumber = context.Set<AccidentDetailsTransaction>()
                .OrderByDescending(x => x.AccidentId)
                .Select(x => x.AccidentId)
                .FirstOrDefault();
            var nextNumber = lastNumber + 1;//assign nextNumber to AccidentID in entity to map model property
           // var id = $"{prefix}{nextNumber:D6}";

           // return id;





            AccidentDetailsTransaction model = new AccidentDetailsTransaction();
            model.AccidentId = nextNumber;



            model.Lat = this.Lat;
            model.Long = this.Long;


            model.DateAndTime = this.DateAndTime;
            // what is the below Psid
            model.Psid = this.Psid;

            model.KebeleName = this.KebeleName;

            model.UserId = this.UserId;

            model.Piname = this.Piname;

            model.PoliceRecordNumber = this.PoliceRecordNumber;

            model.HighwayTypeId = this.HighwayTypeId;

            model.RoadCarriagewayId = this.RoadCarriagewayId;

            model.SpeedLimitId = this.SpeedLimitId;

            model.LandmarkTypeId = this.LandmarkTypeId;

            model.PavementTypeId = this.PavementTypeId;

            model.TerrianTypeId = this.TerrianTypeId;

            model.RoadSurfaceId = this.RoadSurfaceId;

            model.ImpactTypeId = this.ImpactTypeId;

            model.JunctionTypeId = this.JunctionTypeId;

            model.CollisionTypeId = this.CollisionTypeId;

            model.WeatherCondId = this.WeatherCondId;

            model.SeverityId = this.SeverityId;
            model.NumberOfVehicles = this.NumberOfVehicles;
            model.PropertyDamage = this.PropertyDamage;
            model.NumberofVictims = this.NumberofVictims;

            model.Video1 = this.Video1;

            model.Video2 = this.Video2;

            model.Video3 = this.Video3;

            model.Video4 = this.Video4;

            model.Image1 = this.Image1;

            model.Image2 = this.Image2;

            model.Image3 = this.Image3;

            model.Image4 = this.Image4;

            model.Image5 = this.Image5;

            model.Image6 = this.Image6;
            model.SubmissionFlag = this.SubmissionFlag;

            model.CauseofAccidentId = this.CauseofAccidentId;

            model.LightCondtionId = this.LightCondtionId;

            model.Hid = this.Hid;

            model.AirConditionId = this.AirConditionId;

            model.AccidentTypeId = this.AccidentTypeId;

            model.WoredaId = this.WoredaId;

            model.SubCityId = this.SubCityId;

            model.CityId = this.CityId;

            model.RegionId = this.RegionId;

            model.ZoneId = this.ZoneId;

            model.AccidentLocalName = this.AccidentLocalName;


            //model.AccidentTypeId = this.AccidentType.AccidentTypeId;
            //model.AirConditionId = this.AirCondition.AirConditionId;
            //model.CauseofAccidentId = this.CauseofAccident.AccidentCauseId;
            //model.CityId = this.City.CityId;
            //model.AccidentTypeId = this.AccidentType.AccidentTypeId;
            //model.AirConditionId = this.AirCondition.AirConditionId;
            //model.CollisionTypeId = this.CollisionType.CollisionTypeId;
            //model.HighwayTypeId = this.HighwayType.HtypeId;
            //model.ImpactTypeId=this.ImpactType.ImpactTypeId;
            //model.JunctionTypeId=this.JunctionType.JunctionTypeId;
            //model.LandmarkTypeId = this.LandmarkType.LandmarkTypeId;
            //model.LightCondtionId = this.LightCondtion.LightConditionId;
            //model.PavementTypeId=this.PavementType.PavementTypeId;
            //model.Psid = this.Psid;
            //model.RegionId = this.Region.RegionId;
            //model.RoadCarriagewayId = this.RoadCarriageway.RoadCarriagewayId;
            //model.RoadSurfaceId = this.RoadSurface.RoadSurfaceId;
            //model.SeverityId = this.Severity.SeverityId;
            //model.SpeedLimitId = this.SpeedLimit.SpeedLimitId;
            //model.SubCityId = this.SubCity.SubCityId;
            //model.TerrianTypeId=this.TerrianType.TerrianTypeId;
            //model.UserId = this.User.UserId;
            //model.WeatherCondId = this.WeatherCond.WeatherCondId;
            //model.WoredaId = this.Woreda.WoredaId;
       //     model.ZoneId = this.Zone.ZoneId;


           // model.CityId = this.City.CityId;
           //  model.CollisionTypeId = this.CollisionType.CollisionTypeId;




            //model.Woreda =
            return model as T;
        }
    }
}
