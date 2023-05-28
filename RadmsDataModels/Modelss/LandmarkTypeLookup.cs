using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("LandmarkTypeLookup")]
    public partial class LandmarkTypeLookup
    {
        public LandmarkTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("LandmarkTypeID")]
        public int LandmarkTypeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string LandmarkName { get; set; } = null!;
        [StringLength(255)]
        public string? LandmarkNameAm { get; set; }
        [StringLength(255)]
        public string? LandmarkNameOr { get; set; }
        [StringLength(255)]
        public string? LandmarkNameTi { get; set; }
        [StringLength(255)]
        public string? LandmarkNameAf { get; set; }
        [StringLength(255)]
        public string? LandmarkNameSo { get; set; }

        [InverseProperty("LandmarkType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
