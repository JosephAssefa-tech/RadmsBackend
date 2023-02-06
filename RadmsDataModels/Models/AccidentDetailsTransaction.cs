using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("AccidentDetailsTransaction")]
    public partial class AccidentDetailsTransaction
    {
        public AccidentDetailsTransaction()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransaction>();
            VictimDetailsTransactions = new HashSet<VictimDetailsTransaction>();
        }

        public int Lat { get; set; }
        public int Long { get; set; }
        [Key]
        [Column("AccidentID", TypeName = "numeric(18, 0)")]
        public decimal AccidentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateAndTime { get; set; }
        [Column("PSID")]
        [StringLength(6)]
        [Unicode(false)]
        public string Psid { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string? KebeleName { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("PIName")]
        [StringLength(255)]
        [Unicode(false)]
        public string Piname { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string PoliceRecordNumber { get; set; } = null!;
        [Column("HighwayTypeID")]
        public int HighwayTypeId { get; set; }
        [Column("RoadCarriagewayID")]
        public int RoadCarriagewayId { get; set; }
        [Column("SpeedLimitID")]
        public int SpeedLimitId { get; set; }
        [Column("LandmarkTypeID")]
        public int? LandmarkTypeId { get; set; }
        [Column("PavementTypeID")]
        public int PavementTypeId { get; set; }
        [Column("TerrianTypeID")]
        public int TerrianTypeId { get; set; }
        [Column("RoadSurfaceID")]
        public int RoadSurfaceId { get; set; }
        [Column("ImpactTypeID")]
        public int ImpactTypeId { get; set; }
        [Column("JunctionTypeID")]
        public int JunctionTypeId { get; set; }
        [Column("CollisionTypeID")]
        public int CollisionTypeId { get; set; }
        [Column("WeatherCondID")]
        public int WeatherCondId { get; set; }
        [Column("SeverityID")]
        public int SeverityId { get; set; }
        public int NumberOfVehicles { get; set; }
        public int PropertyDamage { get; set; }
        public int NumberofVictims { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Video1 { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Video2 { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Video3 { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Video4 { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Image1 { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Image2 { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Image3 { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Image4 { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Image5 { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Image6 { get; set; }
        public int SubmissionFlag { get; set; }
        [Column("CauseofAccidentID")]
        public int CauseofAccidentId { get; set; }
        [Column("LightCondtionID")]
        public int? LightCondtionId { get; set; }
        [Column("HID")]
        [StringLength(6)]
        [Unicode(false)]
        public string Hid { get; set; } = null!;
        [Column("AirConditionID")]
        public int AirConditionId { get; set; }
        [Column("AccidentTypeID")]
        public int AccidentTypeId { get; set; }
        [Column("WoredaID")]
        public int? WoredaId { get; set; }
        [Column("SubCityID")]
        public int? SubCityId { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }
        [Column("RegionID")]
        public int? RegionId { get; set; }
        [Column("ZoneID")]
        public int? ZoneId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? AccidentLocalName { get; set; }

        [ForeignKey("AccidentTypeId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual AccidentTypeLookup AccidentType { get; set; } = null!;
        [ForeignKey("AirConditionId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual AirConditionTypeLookup AirCondition { get; set; } = null!;
        [ForeignKey("CauseofAccidentId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual AccidentCauseLookup CauseofAccident { get; set; } = null!;
        [ForeignKey("CityId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual CityMaster? City { get; set; }
        [ForeignKey("CollisionTypeId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual CollisionTypeLookup CollisionType { get; set; } = null!;
        [ForeignKey("Hid")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual HighwayMaster HidNavigation { get; set; } = null!;
        [ForeignKey("HighwayTypeId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual HighwayTypeLookup HighwayType { get; set; } = null!;
        [ForeignKey("ImpactTypeId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual ImpactTypeLookup ImpactType { get; set; } = null!;
        [ForeignKey("JunctionTypeId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual JunctionTypeLookup JunctionType { get; set; } = null!;
        [ForeignKey("LandmarkTypeId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual LandmarkTypeLookup? LandmarkType { get; set; }
        [ForeignKey("LightCondtionId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual LightConditionLookup? LightCondtion { get; set; }
        [ForeignKey("PavementTypeId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual PavementTypeLookup PavementType { get; set; } = null!;
        [ForeignKey("Psid")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual PoliceStationMaster Ps { get; set; } = null!;
        [ForeignKey("RegionId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual RegionMaster? Region { get; set; }
        [ForeignKey("RoadCarriagewayId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual RoadCarriagewayTypeLookup RoadCarriageway { get; set; } = null!;
        [ForeignKey("RoadSurfaceId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual RoadSurfaceConditionLookup RoadSurface { get; set; } = null!;
        [ForeignKey("SeverityId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual SeverityLevelLookup Severity { get; set; } = null!;
        [ForeignKey("SpeedLimitId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual SpeedLimitLookup SpeedLimit { get; set; } = null!;
        [ForeignKey("SubCityId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual SubCityMaster? SubCity { get; set; }
        [ForeignKey("TerrianTypeId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual TerrainTypeLookup TerrianType { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual UserMaster User { get; set; } = null!;
        [ForeignKey("WeatherCondId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual WeatherConditionTypeLookup WeatherCond { get; set; } = null!;
        [ForeignKey("WoredaId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual WoredaMaster? Woreda { get; set; }
        [ForeignKey("ZoneId")]
        [InverseProperty("AccidentDetailsTransactions")]
        public virtual ZoneMaster? Zone { get; set; }
        [InverseProperty("Accident")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
        [InverseProperty("Accident")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
