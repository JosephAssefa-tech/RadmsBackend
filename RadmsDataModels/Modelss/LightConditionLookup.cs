using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("LightConditionLookup")]
    public partial class LightConditionLookup
    {
        public LightConditionLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("LightConditionID")]
        public int LightConditionId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string LightConditionName { get; set; } = null!;
        [StringLength(255)]
        public string? LightConditionNameAm { get; set; }
        [StringLength(255)]
        public string? LightConditionNameOr { get; set; }
        [StringLength(255)]
        public string? LightConditionNameTi { get; set; }
        [StringLength(255)]
        public string? LightConditionNameAf { get; set; }
        [StringLength(255)]
        public string? LightConditionNameSo { get; set; }

        [InverseProperty("LightCondtion")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
