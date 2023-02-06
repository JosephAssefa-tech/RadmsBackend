using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("VechicleMaster")]
    public partial class VechicleMaster
    {
        public VechicleMaster()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransaction>();
        }

        [Key]
        [Column("VehicleID")]
        public int VehicleId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string VehicleName { get; set; } = null!;

        [InverseProperty("Vehicle")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
