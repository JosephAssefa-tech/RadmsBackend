using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? VehicleOwnershipNameAm { get; set; }
        [StringLength(255)]
        public string? VehicleOwnershipNameOr { get; set; }
        [StringLength(255)]
        public string? VehicleOwnershipNameTi { get; set; }
        [StringLength(255)]
        public string? VehicleOwnershipNameAf { get; set; }
        [StringLength(255)]
        public string? VehicleOwnershipNameSo { get; set; }

        [InverseProperty("VehicleOwnership")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
