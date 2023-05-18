using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("RoadCarriagewayTypeLookup")]
    public partial class RoadCarriagewayTypeLookup
    {
        public RoadCarriagewayTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
            RoadsInvolvedDetailsTransactions = new HashSet<RoadsInvolvedDetailsTransaction>();
        }

        [Key]
        [Column("RoadCarriagewayID")]
        public int RoadCarriagewayId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string RoadCarriagewayName { get; set; } = null!;
        [StringLength(255)]
        public string? RoadCarriagewayNameAm { get; set; }
        [StringLength(255)]
        public string? RoadCarriagewayNameOr { get; set; }
        [StringLength(255)]
        public string? RoadCarriagewayNameTi { get; set; }
        [StringLength(255)]
        public string? RoadCarriagewayNameAf { get; set; }
        [StringLength(255)]
        public string? RoadCarriagewayNameSo { get; set; }

        [InverseProperty("RoadCarriageway")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
        [InverseProperty("RoadCarriageway")]
        public virtual ICollection<RoadsInvolvedDetailsTransaction> RoadsInvolvedDetailsTransactions { get; set; }
    }
}
