using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("TerrainTypeLookup")]
    public partial class TerrainTypeLookup
    {
        public TerrainTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("TerrianTypeID")]
        public int TerrianTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string TerrianName { get; set; } = null!;
        [StringLength(255)]
        public string? TerrianNameAm { get; set; }
        [StringLength(255)]
        public string? TerrianNameOr { get; set; }
        [StringLength(255)]
        public string? TerrianNameTi { get; set; }
        [StringLength(255)]
        public string? TerrianNameAf { get; set; }
        [StringLength(255)]
        public string? TerrianNameSo { get; set; }

        [InverseProperty("TerrianType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
