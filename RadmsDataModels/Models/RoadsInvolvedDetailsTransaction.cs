using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Keyless]
    [Table("RoadsInvolvedDetailsTransaction")]
    public partial class RoadsInvolvedDetailsTransaction
    {
        [Column("AccidentID", TypeName = "numeric(18, 0)")]
        public decimal? AccidentId { get; set; }
        [Column("HID")]
        [StringLength(6)]
        [Unicode(false)]
        public string Hid { get; set; } = null!;
        [Column("PavementTypeID")]
        public int PavementTypeId { get; set; }
        [Column("RoadSurfaceID")]
        public int RoadSurfaceId { get; set; }
        [Column("RoadCarriagewayID")]
        public int RoadCarriagewayId { get; set; }

        [ForeignKey("AccidentId")]
        public virtual AccidentDetailsTransaction? Accident { get; set; }
        [ForeignKey("Hid")]
        public virtual HighwayMaster HidNavigation { get; set; } = null!;
        [ForeignKey("PavementTypeId")]
        public virtual PavementTypeLookup PavementType { get; set; } = null!;
        [ForeignKey("RoadCarriagewayId")]
        public virtual RoadCarriagewayTypeLookup RoadCarriageway { get; set; } = null!;
        [ForeignKey("RoadSurfaceId")]
        public virtual RoadSurfaceConditionLookup RoadSurface { get; set; } = null!;
    }
}
