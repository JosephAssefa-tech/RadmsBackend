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
        public AccidentDetailsTransactionEntity()
        {
            //VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
            //VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }
        public double Lat { get; set; }
        public double Long { get; set; }

        public decimal AccidentId { get; set; }

        public DateTime DateAndTime { get; set; }

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

        public virtual AccidentTypeLookup AccidentType { get; set; } = null!;

        public virtual AirConditionTypeLookup AirCondition { get; set; } = null!;

        public virtual AccidentCauseLookup CauseofAccident { get; set; } = null!;

        public virtual CityMaster? City { get; set; }

        public virtual CollisionTypeLookup CollisionType { get; set; } = null!;

        public virtual HighwayMaster HidNavigation { get; set; } = null!;

        public virtual HighwayTypeLookup HighwayType { get; set; } = null!;
  
        public virtual ImpactTypeLookup ImpactType { get; set; } = null!;

        public virtual JunctionTypeLookup JunctionType { get; set; } = null!;

        public virtual LandmarkTypeLookup? LandmarkType { get; set; }

        public virtual LightConditionLookup? LightCondtion { get; set; }

        public virtual PavementTypeLookup PavementType { get; set; } = null!;

        public virtual PoliceStationMaster Ps { get; set; } = null!;

        public virtual RegionMaster? Region { get; set; }

        public virtual RoadCarriagewayTypeLookup RoadCarriageway { get; set; } = null!;

        public virtual RoadSurfaceConditionLookup RoadSurface { get; set; } = null!;

        public virtual SeverityLevelLookup Severity { get; set; } = null!;

        public virtual SpeedLimitLookup SpeedLimit { get; set; } = null!;

        public virtual SubCityMaster? SubCity { get; set; }

        public virtual TerrainTypeLookup TerrianType { get; set; } = null!;

        public virtual UserMaster User { get; set; } = null!;

        public virtual WeatherConditionTypeLookup WeatherCond { get; set; } = null!;

        public virtual WoredaMaster? Woreda { get; set; }

        public virtual ZoneMaster? Zone { get; set; }

       // public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

       // public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }



        public AccidentDetailsTransactionEntity(AccidentDetailsTransaction model)
        {
            this.AccidentLocalName = model.AccidentLocalName;

        }

        public T MapToModel<T>() where T : class
        {
            AccidentDetailsTransaction model = new AccidentDetailsTransaction();
            model.AccidentLocalName = this.AccidentLocalName;
            return model as T;
        }
    }
}
