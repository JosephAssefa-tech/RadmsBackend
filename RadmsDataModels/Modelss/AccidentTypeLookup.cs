using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("AccidentTypeLookup")]
    public partial class AccidentTypeLookup
    {
        public AccidentTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("AccidentTypeID")]
        public int AccidentTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string AccidentType { get; set; } = null!;
        [StringLength(255)]
        public string? AccidentTypeAm { get; set; }
        [StringLength(255)]
        public string? AccidentTypeOr { get; set; }
        [StringLength(255)]
        public string? AccidentTypeTi { get; set; }
        [StringLength(255)]
        public string? AccidentTypeAf { get; set; }
        [StringLength(255)]
        public string? AccidentTypeSo { get; set; }

        [InverseProperty("AccidentType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
