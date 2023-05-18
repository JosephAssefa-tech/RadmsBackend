using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("LicenceLevelLookup")]
    public partial class LicenceLevelLookup
    {
        public LicenceLevelLookup()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransaction>();
        }

        [Key]
        [Column("LeveloflicenceID")]
        public int LeveloflicenceId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string LeveloflicenceName { get; set; } = null!;
        [StringLength(255)]
        public string? LeveloflicenceNameAm { get; set; }
        [StringLength(255)]
        public string? LeveloflicenceNameOr { get; set; }
        [StringLength(255)]
        public string? LeveloflicenceNameTi { get; set; }
        [StringLength(255)]
        public string? LeveloflicenceNameAf { get; set; }
        [StringLength(255)]
        public string? LeveloflicenceNameSo { get; set; }

        [InverseProperty("Dllevel")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
