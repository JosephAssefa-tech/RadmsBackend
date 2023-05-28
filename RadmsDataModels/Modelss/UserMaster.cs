using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("UserMaster")]
    public partial class UserMaster
    {
        public UserMaster()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            AuditTrailTransactions = new HashSet<AuditTrailTransaction>();
        }

        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string UserPassword { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string UserName { get; set; } = null!;
        public int UserType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTimeUser { get; set; }
        [Column("OrganizationID")]
        public int? OrganizationId { get; set; }

        [ForeignKey("OrganizationId")]
        [InverseProperty("UserMasters")]
        public virtual OrganizationMaster? Organization { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AuditTrailTransaction> AuditTrailTransactions { get; set; }
    }
}
