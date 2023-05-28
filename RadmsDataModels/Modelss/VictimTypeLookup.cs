using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("VictimTypeLookup")]
    public partial class VictimTypeLookup
    {
        public VictimTypeLookup()
        {
            VictimDetailsTransactions = new HashSet<VictimDetailsTransaction>();
        }

        [Key]
        [Column("VictimTypeID")]
        public int VictimTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string VictimType { get; set; } = null!;
        [StringLength(255)]
        public string? VictimTypeAm { get; set; }
        [StringLength(255)]
        public string? VictimTypeOr { get; set; }
        [StringLength(255)]
        public string? VictimTypeTi { get; set; }
        [StringLength(255)]
        public string? VictimTypeAf { get; set; }
        [StringLength(255)]
        public string? VictimTypeSo { get; set; }

        [InverseProperty("VictimType")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
