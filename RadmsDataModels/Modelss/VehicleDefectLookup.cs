using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("VehicleDefectLookup")]
    public partial class VehicleDefectLookup
    {
        public VehicleDefectLookup()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransaction>();
        }

        [Key]
        [Column("VehicleDefectID")]
        public int VehicleDefectId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string VehicleDefectName { get; set; } = null!;
        [StringLength(255)]
        public string? VehicleDefectNameAm { get; set; }
        [StringLength(255)]
        public string? VehicleDefectNameOr { get; set; }
        [StringLength(255)]
        public string? VehicleDefectNameTi { get; set; }
        [StringLength(255)]
        public string? VehicleDefectNameAf { get; set; }
        [StringLength(255)]
        public string? VehicleDefectNameSo { get; set; }

        [InverseProperty("VehicleDefect")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
