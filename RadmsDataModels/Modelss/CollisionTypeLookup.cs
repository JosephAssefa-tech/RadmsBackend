using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? CollisionTypeNameAm { get; set; }
        [StringLength(255)]
        public string? CollisionTypeNameOr { get; set; }
        [StringLength(255)]
        public string? CollisionTypeNameTi { get; set; }
        [StringLength(255)]
        public string? CollisionTypeNameAf { get; set; }
        [StringLength(255)]
        public string? CollisionTypeNameSo { get; set; }

        [InverseProperty("CollisionType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
