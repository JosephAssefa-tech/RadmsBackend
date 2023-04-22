using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("SeverityLevelLookup")]
    public partial class SeverityLevelLookup
    {
        public SeverityLevelLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            VictimDetailsTransactions = new HashSet<VictimDetailsTransaction>();
        }

        [Key]
        [Column("SeverityID")]
        public int SeverityId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string SeverityType { get; set; } = null!;

        [InverseProperty("Severity")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("Severity")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
