﻿using RadmsDataModels.Models;
using RadmsEntities;
using RadmsWebAPI.ViewModels.BaseModel;

namespace RadmsWebAPI.ViewModels
{
    public class AccidentDetailsTransactionViewModel: ViewBaseModel
    {
        public int Lat { get; set; }
        public int Long { get; set; }
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
        //public virtual AccidentTypeLookup AccidentType { get; set; } = null!;
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
        public AccidentDetailsTransactionViewModel()
        {

        }
        public AccidentDetailsTransactionViewModel(AccidentDetailsTransactionEntity entity)
        {
            this.Lat = entity.Lat;
            this.Long = entity.Long;
            this.AccidentId = entity.AccidentId;
            this.AccidentLocalName = entity.AccidentLocalName;
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
            this.Hid=entity.Hid;
            this.AccidentLocalName = entity.AccidentLocalName;
        }

        public T MapToViewEntity<T>() where T : class
        {
            AccidentDetailsTransactionEntity entity= new AccidentDetailsTransactionEntity();
            entity.Lat = this.Lat;  
            entity.Long = this.Long;
            entity.AccidentId = this.AccidentId;
            entity.AccidentLocalName = this.AccidentLocalName;
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
            return entity as T;


        }
    }
}
