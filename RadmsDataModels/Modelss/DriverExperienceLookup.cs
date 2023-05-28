using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? DriverExperienceNameAm { get; set; }
        [StringLength(255)]
        public string? DriverExperienceNameOr { get; set; }
        [StringLength(255)]
        public string? DriverExperienceNameTi { get; set; }
        [StringLength(255)]
        public string? DriverExperienceNameAf { get; set; }
        [StringLength(255)]
        public string? DriverExperienceNameSo { get; set; }

        [InverseProperty("DriverExperience")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
