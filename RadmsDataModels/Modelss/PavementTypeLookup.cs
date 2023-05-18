using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? PavementNameAm { get; set; }
        [StringLength(255)]
        public string? PavementNameOr { get; set; }
        [StringLength(255)]
        public string? PavementNameTi { get; set; }
        [StringLength(255)]
        public string? PavementNameAf { get; set; }
        [StringLength(255)]
        public string? PavementNameSo { get; set; }

        [InverseProperty("PavementType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("PavementType")]
        public virtual ICollection<RoadsInvolvedDetailsTransaction> RoadsInvolvedDetailsTransactions { get; set; }
    }
}
