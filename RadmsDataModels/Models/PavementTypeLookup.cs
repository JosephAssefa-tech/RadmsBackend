using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("PavementTypeLookup")]
    public partial class PavementTypeLookup
    {
        public PavementTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            RoadsInvolvedDetailsTransactions = new HashSet<RoadsInvolvedDetailsTransaction>();
        }

        [Key]
        [Column("PavementTypeID")]
        public int PavementTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string PavementName { get; set; } = null!;

        [InverseProperty("PavementType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("PavementType")]
        public virtual ICollection<RoadsInvolvedDetailsTransaction> RoadsInvolvedDetailsTransactions { get; set; }
    }
}
