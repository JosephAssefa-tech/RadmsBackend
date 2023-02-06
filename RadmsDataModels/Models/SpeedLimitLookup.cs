using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
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

        [InverseProperty("SpeedLimit")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
