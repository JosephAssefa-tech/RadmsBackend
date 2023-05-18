using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? AccidentCauseNameAm { get; set; }
        [StringLength(255)]
        public string? AccidentCauseNameOr { get; set; }
        [StringLength(255)]
        public string? AccidentCauseNameTi { get; set; }
        [StringLength(255)]
        public string? AccidentCauseNameAf { get; set; }
        [StringLength(255)]
        public string? AccidentCauseNameSo { get; set; }

        [InverseProperty("CauseofAccident")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
