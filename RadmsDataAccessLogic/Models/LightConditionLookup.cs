using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
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

        [InverseProperty("LightCondtion")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
