using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("SeatingTypeLookup")]
    public partial class SeatingTypeLookup
    {
        public SeatingTypeLookup()
        {
            VictimDetailsTransactions = new HashSet<VictimDetailsTransaction>();
        }

        [Key]
        [Column("SeatingTypeID")]
        public int SeatingTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string SeatingTypeName { get; set; } = null!;

        [InverseProperty("SeatingType")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
