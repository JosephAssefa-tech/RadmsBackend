using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("RoadSurfaceConditionLookup")]
    public partial class RoadSurfaceConditionLookup
    {
        public RoadSurfaceConditionLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            RoadsInvolvedDetailsTransactions = new HashSet<RoadsInvolvedDetailsTransaction>();
        }

        [Key]
        [Column("RoadSurfaceID")]
        public int RoadSurfaceId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string RoadSurfaceName { get; set; } = null!;
        [StringLength(255)]
        public string? RoadSurfaceNameAm { get; set; }
        [StringLength(255)]
        public string? RoadSurfaceNameOr { get; set; }
        [StringLength(255)]
        public string? RoadSurfaceNameTi { get; set; }
        [StringLength(255)]
        public string? RoadSurfaceNameAf { get; set; }
        [StringLength(255)]
        public string? RoadSurfaceNameSo { get; set; }

        [InverseProperty("RoadSurface")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("RoadSurface")]
        public virtual ICollection<RoadsInvolvedDetailsTransaction> RoadsInvolvedDetailsTransactions { get; set; }
    }
}
