using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [Column("HTypeNameAm")]
        [StringLength(255)]
        public string? HtypeNameAm { get; set; }
        [Column("HTypeNameOr")]
        [StringLength(255)]
        public string? HtypeNameOr { get; set; }
        [Column("HTypeNameTi")]
        [StringLength(255)]
        public string? HtypeNameTi { get; set; }
        [Column("HTypeNameAf")]
        [StringLength(255)]
        public string? HtypeNameAf { get; set; }
        [Column("HTypeNameSo")]
        [StringLength(255)]
        public string? HtypeNameSo { get; set; }

        [InverseProperty("HighwayType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("Htype")]
        public virtual ICollection<HighwayMaster> HighwayMasters { get; set; }
    }
}
