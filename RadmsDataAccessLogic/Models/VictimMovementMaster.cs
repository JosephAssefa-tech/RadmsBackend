using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
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

        [InverseProperty("VictimMovement")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
