using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("EmploymentStatusLookup")]
    public partial class EmploymentStatusLookup
    {
        public EmploymentStatusLookup()
        {
            VictimDetailsTransactions = new HashSet<VictimDetailsTransaction>();
        }

        [Key]
        [Column("EmploymentStatusID")]
        public int EmploymentStatusId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string EmploymentStatusName { get; set; } = null!;
        [StringLength(255)]
        public string? EmploymentStatusNameAm { get; set; }
        [StringLength(255)]
        public string? EmploymentStatusNameOr { get; set; }
        [StringLength(255)]
        public string? EmploymentStatusNameTi { get; set; }
        [StringLength(255)]
        public string? EmploymentStatusNameAf { get; set; }
        [StringLength(255)]
        public string? EmploymentStatusNameSo { get; set; }

        [InverseProperty("EmploymentStatus")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
