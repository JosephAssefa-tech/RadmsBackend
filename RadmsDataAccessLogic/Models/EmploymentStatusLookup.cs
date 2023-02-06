using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
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

        [InverseProperty("EmploymentStatus")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
