using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
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

        [InverseProperty("AirCondition")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
