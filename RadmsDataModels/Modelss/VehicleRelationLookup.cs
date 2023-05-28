using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? VehicleRelationNameAm { get; set; }
        [StringLength(255)]
        public string? VehicleRelationNameOr { get; set; }
        [StringLength(255)]
        public string? VehicleRelationNameTi { get; set; }
        [StringLength(255)]
        public string? VehicleRelationNameAf { get; set; }
        [StringLength(255)]
        public string? VehicleRelationNameSo { get; set; }

        [InverseProperty("VehicleRelation")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
