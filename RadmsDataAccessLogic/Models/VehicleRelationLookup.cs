using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("VehicleRelationLookup")]
    public partial class VehicleRelationLookup
    {
        public VehicleRelationLookup()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransaction>();
        }

        [Key]
        [Column("VehicleRelationID")]
        public int VehicleRelationId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string VehicleRelationName { get; set; } = null!;

        [InverseProperty("VehicleRelation")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
