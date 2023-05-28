using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("AirConditionTypeLookup")]
    public partial class AirConditionTypeLookup
    {
        public AirConditionTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("AirConditionID")]
        public int AirConditionId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string AirConditionName { get; set; } = null!;
        [StringLength(255)]
        public string? AirConditionNameAm { get; set; }
        [StringLength(255)]
        public string? AirConditionNameOr { get; set; }
        [StringLength(255)]
        public string? AirConditionNameTi { get; set; }
        [StringLength(255)]
        public string? AirConditionNameAf { get; set; }
        [StringLength(255)]
        public string? AirConditionNameSo { get; set; }

        [InverseProperty("AirCondition")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
