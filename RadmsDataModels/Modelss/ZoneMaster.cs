using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("ZoneMaster")]
    public partial class ZoneMaster
    {
        public ZoneMaster()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            WoredaMasters = new HashSet<WoredaMaster>();
        }

        [Key]
        [Column("ZoneID")]
        public int ZoneId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string ZoneName { get; set; } = null!;
        [StringLength(255)]
        public string? ZoneNameAm { get; set; }
        [StringLength(255)]
        public string? ZoneNameOr { get; set; }
        [StringLength(255)]
        public string? ZoneNameTi { get; set; }
        [StringLength(255)]
        public string? ZoneNameAf { get; set; }
        [StringLength(255)]
        public string? ZoneNameSo { get; set; }
        [Column("RegionID")]
        public int? RegionId { get; set; }

        [ForeignKey("RegionId")]
        [InverseProperty("ZoneMasters")]
        public virtual RegionMaster? Region { get; set; }
        [InverseProperty("Zone")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("Zone")]
        public virtual ICollection<WoredaMaster> WoredaMasters { get; set; }
    }
}
