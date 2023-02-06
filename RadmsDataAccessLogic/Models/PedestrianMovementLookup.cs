using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("PedestrianMovementLookup")]
    public partial class PedestrianMovementLookup
    {
        public PedestrianMovementLookup()
        {
            VictimDetailsTransactions = new HashSet<VictimDetailsTransaction>();
        }

        [Key]
        [Column("PedestrianMovementID")]
        public int PedestrianMovementId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string PedestrianMovementName { get; set; } = null!;

        [InverseProperty("PedestrianMovement")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
