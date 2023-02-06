using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
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

        [InverseProperty("Dllevel")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
