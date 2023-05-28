using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("BlackSpotMaster")]
    public partial class BlackSpotMaster
    {
        [Key]
        [Column("BlackSpotID")]
        public int BlackSpotId { get; set; }
        public double BlackSpotLat { get; set; }
        public double BlackSpotLong { get; set; }
        [Column("AccidentID", TypeName = "numeric(18, 0)")]
        public decimal? AccidentId { get; set; }

        [ForeignKey("AccidentId")]
        [InverseProperty("BlackSpotMasters")]
        public virtual AccidentDetailsTransaction? Accident { get; set; }
    }
}
