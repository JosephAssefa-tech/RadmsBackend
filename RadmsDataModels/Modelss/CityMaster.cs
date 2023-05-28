using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("CityMaster")]
    public partial class CityMaster
    {
        public CityMaster()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            SubCityMasters = new HashSet<SubCityMaster>();
        }

        [Key]
        [Column("CityID")]
        public int CityId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string CityName { get; set; } = null!;
        [StringLength(255)]
        public string? CityNameAm { get; set; }
        [StringLength(255)]
        public string? CityNameOr { get; set; }
        [StringLength(255)]
        public string? CityNameTi { get; set; }
        [StringLength(255)]
        public string? CityNameAf { get; set; }
        [StringLength(255)]
        public string? CityNameSo { get; set; }
        [Column("WoredaID")]
        public int? WoredaId { get; set; }

        [ForeignKey("WoredaId")]
        [InverseProperty("CityMasters")]
        public virtual WoredaMaster? Woreda { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<SubCityMaster> SubCityMasters { get; set; }
    }
}
