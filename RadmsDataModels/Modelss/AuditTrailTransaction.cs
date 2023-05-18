using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("AuditTrailTransaction")]
    public partial class AuditTrailTransaction
    {
        [Key]
        [Column("RecordID")]
        [StringLength(15)]
        [Unicode(false)]
        public string RecordId { get; set; } = null!;
        [Column("UserID")]
        public int? UserId { get; set; }
        [Column("ActivityID")]
        public int? ActivityId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTimeAudit { get; set; }
        [Column("FormID")]
        public int? FormId { get; set; }

        [ForeignKey("ActivityId")]
        [InverseProperty("AuditTrailTransactions")]
        public virtual ActivityTypeLookup? Activity { get; set; }
        [ForeignKey("FormId")]
        [InverseProperty("AuditTrailTransactions")]
        public virtual FormMaster? Form { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AuditTrailTransactions")]
        public virtual UserMaster? User { get; set; }
    }
}
