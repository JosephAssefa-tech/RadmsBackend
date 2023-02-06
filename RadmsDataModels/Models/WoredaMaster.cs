using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("WoredaMaster")]
    public partial class WoredaMaster
    {
        public WoredaMaster()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            CityMasters = new HashSet<CityMaster>();
            PoliceStationMasters = new HashSet<PoliceStationMaster>();
        }

        [Key]
        [Column("WoredaID")]
        public int WoredaId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string WoredaName { get; set; } = null!;
        [Column("ZoneID")]
        public int? ZoneId { get; set; }

        [ForeignKey("ZoneId")]
        [InverseProperty("WoredaMasters")]
        public virtual ZoneMaster? Zone { get; set; }
        [InverseProperty("Woreda")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("Woreda")]
        public virtual ICollection<CityMaster> CityMasters { get; set; }
        [InverseProperty("Woreda")]
        public virtual ICollection<PoliceStationMaster> PoliceStationMasters { get; set; }
    }
}
