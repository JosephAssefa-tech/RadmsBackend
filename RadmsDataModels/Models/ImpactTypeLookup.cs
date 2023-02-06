using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("ImpactTypeLookup")]
    public partial class ImpactTypeLookup
    {
        public ImpactTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("ImpactTypeID")]
        public int ImpactTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string ImpactTypeName { get; set; } = null!;

        [InverseProperty("ImpactType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
