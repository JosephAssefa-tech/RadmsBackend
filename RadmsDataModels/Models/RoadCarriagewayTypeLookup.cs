using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("RoadCarriagewayTypeLookup")]
    public partial class RoadCarriagewayTypeLookup
    {
        public RoadCarriagewayTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("RoadCarriagewayID")]
        public int RoadCarriagewayId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string RoadCarriagewayName { get; set; } = null!;

        [InverseProperty("RoadCarriageway")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
