using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("HighwayTypeLookup")]
    public partial class HighwayTypeLookup
    {
        public HighwayTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            HighwayMasters = new HashSet<HighwayMaster>();
        }

        [Key]
        [Column("HTypeID")]
        public int HtypeId { get; set; }
        [Column("HTypeName")]
        [StringLength(255)]
        [Unicode(false)]
        public string HtypeName { get; set; } = null!;

        [InverseProperty("HighwayType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("Htype")]
        public virtual ICollection<HighwayMaster> HighwayMasters { get; set; }
    }
}
