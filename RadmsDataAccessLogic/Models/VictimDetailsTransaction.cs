using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("VictimDetailsTransaction")]
    public partial class VictimDetailsTransaction
    {
        [Column("AccidentID", TypeName = "numeric(18, 0)")]
        public decimal AccidentId { get; set; }
        [Key]
        [Column("VictimID")]
        [StringLength(255)]
        [Unicode(false)]
        public string VictimId { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string VictimName { get; set; } = null!;
        public int Age { get; set; }
        public int GenderType { get; set; }
        [Column("VictimMovementID")]
        public int VictimMovementId { get; set; }
        [Column("VictimTypeID")]
        public int VictimTypeId { get; set; }
        [Column("EmploymentStatusID")]
        public int EmploymentStatusId { get; set; }
        public int? SeatBeltUsed { get; set; }
        public int? AirbadDeployed { get; set; }
        public int? HelmetUsed { get; set; }
        [Column("HealthConditionID")]
        public int? HealthConditionId { get; set; }
        [Column("PedestrianMovementID")]
        public int? PedestrianMovementId { get; set; }
        [Column("SeatingTypeID")]
        public int? SeatingTypeId { get; set; }

        [ForeignKey("AccidentId")]
        [InverseProperty("VictimDetailsTransactions")]
        public virtual AccidentDetailsTransaction Accident { get; set; } = null!;
        [ForeignKey("EmploymentStatusId")]
        [InverseProperty("VictimDetailsTransactions")]
        public virtual EmploymentStatusLookup EmploymentStatus { get; set; } = null!;
        [ForeignKey("HealthConditionId")]
        [InverseProperty("VictimDetailsTransactions")]
        public virtual HealthConditionLookup? HealthCondition { get; set; }
        [ForeignKey("PedestrianMovementId")]
        [InverseProperty("VictimDetailsTransactions")]
        public virtual PedestrianMovementLookup? PedestrianMovement { get; set; }
        [ForeignKey("SeatingTypeId")]
        [InverseProperty("VictimDetailsTransactions")]
        public virtual SeatingTypeLookup? SeatingType { get; set; }
        [ForeignKey("VictimMovementId")]
        [InverseProperty("VictimDetailsTransactions")]
        public virtual VictimMovementMaster VictimMovement { get; set; } = null!;
        [ForeignKey("VictimTypeId")]
        [InverseProperty("VictimDetailsTransactions")]
        public virtual VictimTypeLookup VictimType { get; set; } = null!;
    }
}
