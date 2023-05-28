using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("SpeedLimitLookup")]
    public partial class SpeedLimitLookup
    {
        public SpeedLimitLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("SpeedLimitID")]
        public int SpeedLimitId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string SpeedLimitName { get; set; } = null!;
        [StringLength(255)]
        public string? SpeedLimitNameAm { get; set; }
        [StringLength(255)]
        public string? SpeedLimitNameOr { get; set; }
        [StringLength(255)]
        public string? SpeedLimitNameTi { get; set; }
        [StringLength(255)]
        public string? SpeedLimitNameAf { get; set; }
        [StringLength(255)]
        public string? SpeedLimitNameSo { get; set; }

        [InverseProperty("SpeedLimit")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
