using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("HealthConditionLookup")]
    public partial class HealthConditionLookup
    {
        public HealthConditionLookup()
        {
            VictimDetailsTransactions = new HashSet<VictimDetailsTransaction>();
        }

        [Key]
        [Column("HealthConditionID")]
        public int HealthConditionId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string HealthConditionName { get; set; } = null!;

        [InverseProperty("HealthCondition")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
