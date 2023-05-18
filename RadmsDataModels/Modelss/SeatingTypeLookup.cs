using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? SeatingTypeNameAm { get; set; }
        [StringLength(255)]
        public string? SeatingTypeNameOr { get; set; }
        [StringLength(255)]
        public string? SeatingTypeNameTi { get; set; }
        [StringLength(255)]
        public string? SeatingTypeNameAf { get; set; }
        [StringLength(255)]
        public string? SeatingTypeNameSo { get; set; }

        [InverseProperty("SeatingType")]
        public virtual ICollection<VictimDetailsTransaction> VictimDetailsTransactions { get; set; }
    }
}
