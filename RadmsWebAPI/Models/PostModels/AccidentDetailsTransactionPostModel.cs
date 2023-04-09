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
        //public virtual AccidentTypeLookupPostModel AccidentType { get; set; } = null!;
        //public virtual AirConditionTypeLookupPostModel AirCondition { get; set; } = null!;
        //public virtual AccidentCauseLookupPostModel CauseofAccident { get; set; } = null!;
        //public virtual CityMasterPostModel? City { get; set; }
        //public virtual CollisionTypeLookupPostModel CollisionType { get; set; } = null!;
        //public virtual HighwayMasterPostModel HidNavigation { get; set; } = null!;
        //public virtual HighwayTypeLookupPostModel HighwayType { get; set; } = null!;
        //public virtual ImpactTypeLookupPostModel ImpactType { get; set; } = null!;
        //public virtual JunctionTypeLookupPostModel JunctionType { get; set; } = null!;
        //public virtual LandmarkTypeLookupPostModel? LandmarkType { get; set; }
        //public virtual LightConditionLookupPostModel? LightCondtion { get; set; }
        //public virtual PavementTypeLookupPostModel PavementType { get; set; } = null!;
        //public virtual PoliceStationMasterPostModel Ps { get; set; } = null!;
        //public virtual RegionMasterPostModel? Region { get; set; }
        //public virtual RoadCarriagewayTypeLookupPostModel RoadCarriageway { get; set; } = null!;
        //public virtual RoadSurfaceConditionLookupPostModel RoadSurface { get; set; } = null!;
        //public virtual SeverityLevelLookupPostModel Severity { get; set; } = null!;
        //public virtual SpeedLimitLookupPostModel SpeedLimit { get; set; } = null!;
        //public virtual SubCityMasterPostModel? SubCity { get; set; }
        //public virtual TerrainTypeLookupPostModel TerrianType { get; set; } = null!;
        //public virtual UserMasterPostModel User { get; set; } = null!;
        //public virtual WeatherConditionTypeLookupPostModel WeatherCond { get; set; } = null!;
        //public virtual WoredaMasterPostModel? Woreda { get; set; }
        //public virtual ZoneMasterPostModel? Zone { get; set; }
        ////public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
        // public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
        public AccidentDetailsTransactionPostModel()
        {

        }
        public AccidentDetailsTransactionPostModel(AccidentDetailsTransactionEntity entity)
        {
            


            this.Lat = entity.Lat;
            this.Long = entity.Long;
            this.AccidentId = (decimal)entity.AccidentId;

            this.DateAndTime = entity.DateAndTime;
            // what is the below Psid
            this.Psid = entity.Psid;

            this.KebeleName = entity.KebeleName;

            this.UserId = entity.UserId;

            this.Piname = entity.Piname;

            this.PoliceRecordNumber = entity.PoliceRecordNumber;

            this.HighwayTypeId = entity.HighwayTypeId;

            this.RoadCarriagewayId = entity.RoadCarriagewayId;

            this.SpeedLimitId = entity.SpeedLimitId;

            this.LandmarkTypeId = entity.LandmarkTypeId;

            this.PavementTypeId = entity.PavementTypeId;

            this.TerrianTypeId = entity.TerrianTypeId;

            this.RoadSurfaceId = entity.RoadSurfaceId;

            this.ImpactTypeId = entity.ImpactTypeId;

            this.JunctionTypeId = entity.JunctionTypeId;

            this.CollisionTypeId = entity.CollisionTypeId;

            this.WeatherCondId = entity.WeatherCondId;

            this.SeverityId = entity.SeverityId;
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

            this.CauseofAccidentId = entity.CauseofAccidentId;

            this.LightCondtionId = entity.LightCondtionId;

            this.Hid = entity.Hid;

            this.AirConditionId = entity.AirConditionId;

            this.AccidentTypeId = entity.AccidentTypeId;

            this.WoredaId = entity.WoredaId;

            this.SubCityId = entity.SubCityId;

            this.CityId = entity.CityId;

            this.RegionId = entity.RegionId;

            this.ZoneId = entity.ZoneId;

            this.AccidentLocalName = entity.AccidentLocalName;

            //this.LandmarkType = new LandmarkTypeLookupPostModel(entity.LandmarkType);
            //this.AccidentType = new AccidentTypeLookupPostModel(entity.AccidentType);
            //this.AirCondition = new AirConditionTypeLookupPostModel(entity.AirCondition);
            //this.City = new CityMasterPostModel(entity.City);
            //this.Region = new RegionMasterPostModel(entity.Region);
            //this.Woreda = new WoredaMasterPostModel(entity.Woreda);
            //this.Zone = new ZoneMasterPostModel(entity.Zone);
            //this.CollisionType = new CollisionTypeLookupPostModel(entity.CollisionType);
            //this.HidNavigation = new HighwayMasterPostModel(entity.HidNavigation);
            //this.HighwayType = new HighwayTypeLookupPostModel(entity.HighwayType);
            //this.ImpactType =new ImpactTypeLookupPostModel(entity.ImpactType);
            //this.JunctionType =new JunctionTypeLookupPostModel(entity.JunctionType);
            //this.LightCondtion =new LightConditionLookupPostModel(entity.LightCondtion);
            //this.SubCity =new SubCityMasterPostModel(entity.SubCity);
            //this.WeatherCond = new WeatherConditionTypeLookupPostModel(entity.WeatherCond);
            //this.User = new UserMasterPostModel(entity.User);
            //this.TerrianType = new TerrainTypeLookupPostModel(entity.TerrianType);
            //this.SpeedLimit =new SpeedLimitLookupPostModel(entity.SpeedLimit);
            //this.Severity = new SeverityLevelLookupPostModel(entity.Severity);
            //this.RoadCarriageway = new RoadCarriagewayTypeLookupPostModel(entity.RoadCarriageway);
            //this.RoadSurface = new RoadSurfaceConditionLookupPostModel(entity.RoadSurface);

        }

        public T MapToViewEntity<T>() where T : class
        {
            AccidentDetailsTransactionEntity entity = new AccidentDetailsTransactionEntity();
            entity.AccidentId = this.AccidentId==null? 0 : (decimal)this.AccidentId;

            entity.Lat = this.Lat;
            entity.Long = this.Long;
            entity.AccidentId = (decimal)this.AccidentId;

            entity.DateAndTime = this.DateAndTime;
            // what is the below Psid
            entity.Psid = this.Psid;

            entity.KebeleName = this.KebeleName; 

            entity.UserId = this.UserId;

            entity.Piname = this.Piname;

            entity.PoliceRecordNumber = this.PoliceRecordNumber;

            entity.HighwayTypeId = this.HighwayTypeId;

            entity.RoadCarriagewayId = this.RoadCarriagewayId;

            entity.SpeedLimitId = this.SpeedLimitId;

            entity.LandmarkTypeId = this.LandmarkTypeId;

            entity.PavementTypeId = this.PavementTypeId;

            entity.TerrianTypeId = this.TerrianTypeId;

            entity.RoadSurfaceId = this.RoadSurfaceId;

            entity.ImpactTypeId = this.ImpactTypeId;

            entity.JunctionTypeId = this.JunctionTypeId;

            entity.CollisionTypeId = this.CollisionTypeId;

            entity.WeatherCondId = this.WeatherCondId;

            entity.SeverityId = this.SeverityId;
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

            entity.CauseofAccidentId = this.CauseofAccidentId;

            entity.LightCondtionId = this.LightCondtionId;

            entity.Hid = this.Hid;

            entity.AirConditionId = this.AirConditionId;

            entity.AccidentTypeId = this.AccidentTypeId;

            entity.WoredaId = this.WoredaId;

            entity.SubCityId = this.SubCityId;

            entity.CityId = this.CityId;

            entity.RegionId = this.RegionId;

            entity.ZoneId = this.ZoneId;

            entity.AccidentLocalName = this.AccidentLocalName;



            //  entity.Hid = this.Hid;
            // entity.SpeedLimitId = this.SpeedLimitId;
            //   entity.AccidentType = this.AccidentType.MapToViewEntity<AccidentTypeLookupEntity>();
            //   entity.AirCondition = this.AirCondition.MapToViewEntity<AirConditionTypeLookupEntity>();
            //   entity.CauseofAccident = this.CauseofAccident.MapToViewEntity<AccidentCauseLookupEntity>();
            //   entity.City = this.City.MapToViewEntity<CityMasterEntity>();
            //   entity.Region = this.Region.MapToViewEntity<RegionMasterEntity>();
            //   entity.Woreda = this.Woreda.MapToViewEntity<WoredaMasterEntity>();
            //entity.Zone = this.Zone.MapToViewEntity<ZoneMasterEntity>();
            //   entity.PavementType=this.PavementType.MapToViewEntity<PavementTypeLookupEntity>();
            //   entity.LandmarkType = this.LandmarkType.MapToViewEntity<LandmarkTypeLookupEntity>();
            //   entity.TerrianType = this.TerrianType.MapToViewEntity<TerrainTypeLookupEntity>();
            //   entity.CollisionType = this.CollisionType.MapToViewEntity<CollisionTypeLookupEntity>();
            //   entity.HidNavigation = this.HidNavigation.MapToViewEntity<HighwayMasterEntity>();
            //   entity.HighwayType = this.HighwayType.MapToViewEntity<HighwayTypeLookupEntity>();
            //   entity.ImpactType = this.ImpactType.MapToViewEntity<ImpactTypeLookupEntity>();
            //   entity.JunctionType = this.JunctionType.MapToViewEntity<JunctionTypeLookupEntity>();
            //   entity.LightCondtion = this.LightCondtion.MapToViewEntity<LightConditionLookupEntity>();
            //   entity.SubCity = this.SubCity.MapToViewEntity<SubCityMasterEntity>();
            //   entity.WeatherCond = this.WeatherCond.MapToViewEntity<WeatherConditionTypeLookupEntity>();
            //   entity.User = this.User.MapToViewEntity<UserMasterEntity>();
            //   entity.SpeedLimit = this.SpeedLimit.MapToViewEntity<SpeedLimitLookupEntity>();
            //   entity.Severity = this.Severity.MapToViewEntity<SeverityLevelLookupEntity>();
            //   entity.RoadCarriageway = this.RoadCarriageway.MapToViewEntity<RoadCarriagewayTypeLookupEntity>();
            //   entity.RoadSurface = this.RoadSurface.MapToViewEntity<RoadSurfaceConditionLookupEntity>();



            return entity as T;


        }
    }
}
