using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Keyless]
    [Table("LegalMeasurementDetailsTransaction")]
    public partial class LegalMeasurementDetailsTransaction
    {
        [Column("AccidentID", TypeName = "numeric(18, 0)")]
        public decimal? AccidentId { get; set; }
        [Column("VictimID")]
        [StringLength(255)]
        [Unicode(false)]
        public string? VictimId { get; set; }
        public bool? IsSuspended { get; set; }
        [Column("ISUnderInvestigation")]
        public bool? IsunderInvestigation { get; set; }
        public bool? IsDeadFile { get; set; }
        public bool? IsRemand { get; set; }
        public bool? IsReleaseFree { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Imprisonment { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? MoneyDesposit { get; set; }

        [ForeignKey("AccidentId")]
        public virtual AccidentDetailsTransaction? Accident { get; set; }
        [ForeignKey("VictimId")]
        public virtual VictimDetailsTransaction? Victim { get; set; }
    }
}
