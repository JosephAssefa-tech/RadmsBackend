using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("VehicleDetailsTransaction")]
    public partial class VehicleDetailsTransaction
    {
        [Column("AccidentID", TypeName = "numeric(18, 0)")]
        public decimal AccidentId { get; set; }
        [Key]
        [Column("VehicleInvolvedID", TypeName = "numeric(18, 0)")]
        public decimal VehicleInvolvedId { get; set; }
        [Column("VehicleID")]
        public int VehicleId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? NumberPlate { get; set; }
        [Column("VehicleAgeID")]
        public int? VehicleAgeId { get; set; }
        [Column("VehicleDefectID")]
        public int? VehicleDefectId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? DriverName { get; set; }
        [Column("DLCatagoryID")]
        public int DlcatagoryId { get; set; }
        public int DriverAge { get; set; }
        [Column("EducationLevelID")]
        public int? EducationLevelId { get; set; }
        [Column("DriverExperienceID")]
        public int? DriverExperienceId { get; set; }
        [Column("VehicleOwnershipID")]
        public int VehicleOwnershipId { get; set; }
        [Column("GenderID")]
        public int GenderId { get; set; }
        [Column("DLStatus")]
        public int Dlstatus { get; set; }
        [Column("DLLevelID")]
        public int? DllevelId { get; set; }
        [Column("DLNumber")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Dlnumber { get; set; }
        [Column("VehicleRelationID")]
        public int? VehicleRelationId { get; set; }
        [Column("VehicleMovementID")]
        public int VehicleMovementId { get; set; }
        public int? IsOverSpeed { get; set; }
        public int? RecordedSpeed { get; set; }
        public int? IsAlcohalConsumed { get; set; }
        public int? AlcohalConsumptionLevel { get; set; }
        public int ValidInsurance { get; set; }
        public int AccuseStatus { get; set; }

        [ForeignKey("AccidentId")]
        [InverseProperty("VehicleDetailsTransactions")]
        public virtual AccidentDetailsTransaction Accident { get; set; } = null!;
        [ForeignKey("DlcatagoryId")]
        [InverseProperty("VehicleDetailsTransactions")]
        public virtual DrivingLicenceCatagoryLookup Dlcatagory { get; set; } = null!;
        [ForeignKey("DllevelId")]
        [InverseProperty("VehicleDetailsTransactions")]
        public virtual LicenceLevelLookup? Dllevel { get; set; }
        [ForeignKey("DriverExperienceId")]
        [InverseProperty("VehicleDetailsTransactions")]
        public virtual DriverExperienceLookup? DriverExperience { get; set; }
        [ForeignKey("EducationLevelId")]
        [InverseProperty("VehicleDetailsTransactions")]
        public virtual EducationLevelLookup? EducationLevel { get; set; }
        [ForeignKey("VehicleId")]
        [InverseProperty("VehicleDetailsTransactions")]
        public virtual VechicleMaster Vehicle { get; set; } = null!;
        [ForeignKey("VehicleAgeId")]
        [InverseProperty("VehicleDetailsTransactions")]
        public virtual VehicleServiceAgeLookup? VehicleAge { get; set; }
        [ForeignKey("VehicleDefectId")]
        [InverseProperty("VehicleDetailsTransactions")]
        public virtual VehicleDefectLookup? VehicleDefect { get; set; }
        [ForeignKey("VehicleMovementId")]
        [InverseProperty("VehicleDetailsTransactions")]
        public virtual VehicleMovementMaster VehicleMovement { get; set; } = null!;
        [ForeignKey("VehicleOwnershipId")]
        [InverseProperty("VehicleDetailsTransactions")]
        public virtual VehicleOwnershipLookup VehicleOwnership { get; set; } = null!;
        [ForeignKey("VehicleRelationId")]
        [InverseProperty("VehicleDetailsTransactions")]
        public virtual VehicleRelationLookup? VehicleRelation { get; set; }
    }
}
