using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
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

        [InverseProperty("TerrianType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
