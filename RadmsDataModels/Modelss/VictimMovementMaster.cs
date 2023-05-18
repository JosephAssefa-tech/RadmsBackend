using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("VictimMovementMaster")]
    public partial class VictimMovementMaster
    {
        public VictimMovementMaster()
        {
            VictimDetailsTransactions = new HashSet<VictimDetailsTransaction>();
        }

        [Key]
        [Column("VictimMovementID")]
        public int VictimMovementId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string VictimMovementType { get; set; } = null!;
        [StringLength(255)]
        public string? VictimMovementTypeAm { get; set; }
        [StringLength(255)]
        public string? VictimMovementTypeOr { get; set; }
        [StringLength(255)]
        public string? VictimMovementTypeTi { get; set; }
        [StringLength(255)]
        public string? VictimMovementTypeAf { get; set; }
        [StringLength(255)]
        public string? VictimMovementTypeSo { get; set; }

        [InverseProperty("VictimMovement")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
