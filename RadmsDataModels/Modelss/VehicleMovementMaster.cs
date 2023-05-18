using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? VehicleMovementMasterNameAm { get; set; }
        [StringLength(255)]
        public string? VehicleMovementMasterNameOr { get; set; }
        [StringLength(255)]
        public string? VehicleMovementMasterNameTi { get; set; }
        [StringLength(255)]
        public string? VehicleMovementMasterNameAf { get; set; }
        [StringLength(255)]
        public string? VehicleMovementMasterNameSo { get; set; }

        [InverseProperty("VehicleMovement")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
