using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
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

        [InverseProperty("VictimType")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
