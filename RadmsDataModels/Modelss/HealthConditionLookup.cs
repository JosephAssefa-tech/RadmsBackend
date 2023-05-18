using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? HealthConditionNameAm { get; set; }
        [StringLength(255)]
        public string? HealthConditionNameOr { get; set; }
        [StringLength(255)]
        public string? HealthConditionNameTi { get; set; }
        [StringLength(255)]
        public string? HealthConditionNameAf { get; set; }
        [StringLength(255)]
        public string? HealthConditionNameSo { get; set; }

        [InverseProperty("HealthCondition")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
