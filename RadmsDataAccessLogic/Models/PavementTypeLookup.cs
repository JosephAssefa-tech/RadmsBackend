using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("PavementTypeLookup")]
    public partial class PavementTypeLookup
    {
        public PavementTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("PavementTypeID")]
        public int PavementTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string PavementName { get; set; } = null!;

        [InverseProperty("PavementType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
