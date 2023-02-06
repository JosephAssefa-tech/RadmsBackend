using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("CollisionTypeLookup")]
    public partial class CollisionTypeLookup
    {
        public CollisionTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("CollisionTypeID")]
        public int CollisionTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string CollisionTypeName { get; set; } = null!;

        [InverseProperty("CollisionType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
