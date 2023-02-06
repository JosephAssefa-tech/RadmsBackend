using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("VehicleOwnershipLookup")]
    public partial class VehicleOwnershipLookup
    {
        public VehicleOwnershipLookup()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransaction>();
        }

        [Key]
        [Column("VehicleOwnershipID")]
        public int VehicleOwnershipId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string VehicleOwnershipName { get; set; } = null!;

        [InverseProperty("VehicleOwnership")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
