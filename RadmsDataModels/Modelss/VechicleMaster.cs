using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? VehicleNameAm { get; set; }
        [StringLength(255)]
        public string? VehicleNameOr { get; set; }
        [StringLength(255)]
        public string? VehicleNameTi { get; set; }
        [StringLength(255)]
        public string? VehicleNameAf { get; set; }
        [StringLength(255)]
        public string? VehicleNameSo { get; set; }

        [InverseProperty("Vehicle")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
