using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("AccidentTypeLookup")]
    public partial class AccidentTypeLookup
    {
        public AccidentTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("AccidentTypeID")]
        public int AccidentTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string AccidentType { get; set; } = null!;

        [InverseProperty("AccidentType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
