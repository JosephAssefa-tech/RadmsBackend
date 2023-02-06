using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
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

        [InverseProperty("VehicleAge")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
