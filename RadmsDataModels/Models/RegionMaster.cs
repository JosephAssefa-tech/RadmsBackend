using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("RegionMaster")]
    public partial class RegionMaster
    {
        public RegionMaster()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            ZoneMasters = new HashSet<ZoneMaster>();
        }

        [Key]
        [Column("RegionID")]
        public int RegionId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string RegionName { get; set; } = null!;

        [InverseProperty("Region")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("Region")]
        public virtual ICollection<ZoneMaster> ZoneMasters { get; set; }
    }
}
