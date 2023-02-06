using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("DriverExperienceLookup")]
    public partial class DriverExperienceLookup
    {
        public DriverExperienceLookup()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransaction>();
        }

        [Key]
        [Column("DriverExperienceID")]
        public int DriverExperienceId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string DriverExperienceName { get; set; } = null!;

        [InverseProperty("DriverExperience")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
