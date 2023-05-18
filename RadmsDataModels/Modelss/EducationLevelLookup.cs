using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("EducationLevelLookup")]
    public partial class EducationLevelLookup
    {
        public EducationLevelLookup()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransaction>();
        }

        [Key]
        [Column("EducationLevelID")]
        public int EducationLevelId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string EducationLevelName { get; set; } = null!;
        [StringLength(255)]
        public string? EducationLevelNameAm { get; set; }
        [StringLength(255)]
        public string? EducationLevelNameOr { get; set; }
        [StringLength(255)]
        public string? EducationLevelNameTi { get; set; }
        [StringLength(255)]
        public string? EducationLevelNameAf { get; set; }
        [StringLength(255)]
        public string? EducationLevelNameSo { get; set; }

        [InverseProperty("EducationLevel")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
