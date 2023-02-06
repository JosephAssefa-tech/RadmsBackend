using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("VehicleMovementMaster")]
    public partial class VehicleMovementMaster
    {
        public VehicleMovementMaster()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransaction>();
        }

        [Key]
        [Column("VehicleMovementID")]
        public int VehicleMovementId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string VehicleMovementMasterName { get; set; } = null!;

        [InverseProperty("VehicleMovement")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
