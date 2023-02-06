using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("AccidentCauseLookup")]
    public partial class AccidentCauseLookup
    {
        public AccidentCauseLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("AccidentCauseID")]
        public int AccidentCauseId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string AccidentCauseName { get; set; } = null!;

        [InverseProperty("CauseofAccident")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
