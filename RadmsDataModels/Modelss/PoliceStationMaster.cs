using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("PoliceStationMaster")]
    public partial class PoliceStationMaster
    {
        public PoliceStationMaster()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("PSID")]
        [StringLength(6)]
        [Unicode(false)]
        public string Psid { get; set; } = null!;
        [Column("PSName")]
        [StringLength(255)]
        [Unicode(false)]
        public string Psname { get; set; } = null!;
        [Column("PSNameAm")]
        [StringLength(255)]
        public string? PsnameAm { get; set; }
        [Column("PSNameOr")]
        [StringLength(255)]
        public string? PsnameOr { get; set; }
        [Column("PSNameTi")]
        [StringLength(255)]
        public string? PsnameTi { get; set; }
        [Column("PSNameAf")]
        [StringLength(255)]
        public string? PsnameAf { get; set; }
        [Column("PSNameSo")]
        [StringLength(255)]
        public string? PsnameSo { get; set; }
        [Column("SubCityID")]
        public int? SubCityId { get; set; }
        [Column("WoredaID")]
        public int? WoredaId { get; set; }

        [ForeignKey("SubCityId")]
        [InverseProperty("PoliceStationMasters")]
        public virtual SubCityMaster? SubCity { get; set; }
        [ForeignKey("WoredaId")]
        [InverseProperty("PoliceStationMasters")]
        public virtual WoredaMaster? Woreda { get; set; }
        [InverseProperty("Ps")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
