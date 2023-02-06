using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
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

        [InverseProperty("EducationLevel")]
        public virtual ICollection<VehicleDetailsTransaction> VehicleDetailsTransactions { get; set; }
    }
}
