using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
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

        [InverseProperty("VehicleDefect")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
