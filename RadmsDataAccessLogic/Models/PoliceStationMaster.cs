using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
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
