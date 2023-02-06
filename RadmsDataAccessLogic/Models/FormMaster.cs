using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("FormMaster")]
    public partial class FormMaster
    {
        public FormMaster()
        {
            AuditTrailTransactions = new HashSet<AuditTrailTransaction>();
            UserRoleTransactions = new HashSet<UserRoleTransaction>();
        }

        [Key]
        [Column("FormID")]
        public int FormId { get; set; }
        [Column("FormURL")]
        [StringLength(255)]
        [Unicode(false)]
        public string FormUrl { get; set; } = null!;

        [InverseProperty("Form")]
        public virtual ICollection<AuditTrailTransaction> AuditTrailTransactions { get; set; }
        [InverseProperty("Form")]
        public virtual ICollection<UserRoleTransaction> UserRoleTransactions { get; set; }
    }
}
