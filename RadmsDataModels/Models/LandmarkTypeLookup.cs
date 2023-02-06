using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
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

        [InverseProperty("LandmarkType")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
