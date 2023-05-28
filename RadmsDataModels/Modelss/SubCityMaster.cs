using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("SubCityMaster")]
    public partial class SubCityMaster
    {
        public SubCityMaster()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            PoliceStationMasters = new HashSet<PoliceStationMaster>();
        }

        [Key]
        [Column("SubCityID")]
        public int SubCityId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string SubCityName { get; set; } = null!;
        [StringLength(255)]
        public string? SubCityNameAm { get; set; }
        [StringLength(255)]
        public string? SubCityNameOr { get; set; }
        [StringLength(255)]
        public string? SubCityNameTi { get; set; }
        [StringLength(255)]
        public string? SubCityNameAf { get; set; }
        [StringLength(255)]
        public string? SubCityNameSo { get; set; }
        [Column("CityID")]
        public int? CityId { get; set; }

        [ForeignKey("CityId")]
        [InverseProperty("SubCityMasters")]
        public virtual CityMaster? City { get; set; }
        [InverseProperty("SubCity")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("SubCity")]
        public virtual ICollection<PoliceStationMaster> PoliceStationMasters { get; set; }
    }
}
