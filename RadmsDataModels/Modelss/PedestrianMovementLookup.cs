using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? PedestrianMovementNameAm { get; set; }
        [StringLength(255)]
        public string? PedestrianMovementNameOr { get; set; }
        [StringLength(255)]
        public string? PedestrianMovementNameTi { get; set; }
        [StringLength(255)]
        public string? PedestrianMovementNameAf { get; set; }
        [StringLength(255)]
        public string? PedestrianMovementNameSo { get; set; }

        [InverseProperty("PedestrianMovement")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
