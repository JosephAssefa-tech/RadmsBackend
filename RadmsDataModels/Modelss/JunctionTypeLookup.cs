using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("JunctionTypeLookup")]
    public partial class JunctionTypeLookup
    {
        public JunctionTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("JunctionTypeID")]
        public int JunctionTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string JunctionTypeName { get; set; } = null!;
        [StringLength(255)]
        public string? JunctionTypeNameAm { get; set; }
        [StringLength(255)]
        public string? JunctionTypeNameOr { get; set; }
        [StringLength(255)]
        public string? JunctionTypeNameTi { get; set; }
        [StringLength(255)]
        public string? JunctionTypeNameAf { get; set; }
        [StringLength(255)]
        public string? JunctionTypeNameSo { get; set; }
        public int JunctionNoOfRoads { get; set; }

        [InverseProperty("JunctionType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
