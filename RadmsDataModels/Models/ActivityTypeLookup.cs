using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("ActivityTypeLookup")]
    public partial class ActivityTypeLookup
    {
        public ActivityTypeLookup()
        {
            AuditTrailTransactions = new HashSet<AuditTrailTransaction>();
        }

        [Key]
        [Column("ActivityID")]
        public int ActivityId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string ActivityName { get; set; } = null!;

        [InverseProperty("Activity")]
        public virtual ICollection<AuditTrailTransaction> AuditTrailTransactions { get; set; }
    }
}
