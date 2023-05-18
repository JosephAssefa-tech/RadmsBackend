using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("HighwayMaster")]
    public partial class HighwayMaster
    {
        public HighwayMaster()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            RoadsInvolvedDetailsTransactions = new HashSet<RoadsInvolvedDetailsTransaction>();
        }

        [Key]
        [Column("HID")]
        [StringLength(6)]
        [Unicode(false)]
        public string Hid { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string Hname { get; set; } = null!;
        [StringLength(255)]
        public string? HnameAm { get; set; }
        [StringLength(255)]
        public string? HnameOr { get; set; }
        [StringLength(255)]
        public string? HnameTi { get; set; }
        [StringLength(255)]
        public string? HnameAf { get; set; }
        [StringLength(255)]
        public string? HnameSo { get; set; }
        [Column("HTypeID")]
        public int? HtypeId { get; set; }
        [Column("HOwnerID")]
        [StringLength(3)]
        [Unicode(false)]
        public string? HownerId { get; set; }
        public int? Hlength { get; set; }
        public int? StartChange { get; set; }
        public int? EndChanage { get; set; }

        [ForeignKey("HownerId")]
        [InverseProperty("HighwayMasters")]
        public virtual HighwayOwnerMaster? Howner { get; set; }
        [ForeignKey("HtypeId")]
        [InverseProperty("HighwayMasters")]
        public virtual HighwayTypeLookup? Htype { get; set; }
        [InverseProperty("HidNavigation")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("HidNavigation")]
        public virtual ICollection<RoadsInvolvedDetailsTransaction> RoadsInvolvedDetailsTransactions { get; set; }
    }
}
