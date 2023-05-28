using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("VehicleServiceAgeLookup")]
    public partial class VehicleServiceAgeLookup
    {
        public VehicleServiceAgeLookup()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransaction>();
        }

        [Key]
        [Column("VehicleServiceAgeID")]
        public int VehicleServiceAgeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string VehicleServiceName { get; set; } = null!;
        [StringLength(255)]
        public string? VehicleServiceNameAm { get; set; }
        [StringLength(255)]
        public string? VehicleServiceNameOr { get; set; }
        [StringLength(255)]
        public string? VehicleServiceNameTi { get; set; }
        [StringLength(255)]
        public string? VehicleServiceNameAf { get; set; }
        [StringLength(255)]
        public string? VehicleServiceNameSo { get; set; }

        [InverseProperty("VehicleAge")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
