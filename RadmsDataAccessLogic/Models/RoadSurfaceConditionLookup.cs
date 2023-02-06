using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("RoadSurfaceConditionLookup")]
    public partial class RoadSurfaceConditionLookup
    {
        public RoadSurfaceConditionLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("RoadSurfaceID")]
        public int RoadSurfaceId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string RoadSurfaceName { get; set; } = null!;

        [InverseProperty("RoadSurface")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
