﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("HighwayOwnerMaster")]
    public partial class HighwayOwnerMaster
    {
        public HighwayOwnerMaster()
        {
            HighwayMasters = new HashSet<HighwayMaster>();
        }

        [Key]
        [Column("HOwnerID")]
        [StringLength(3)]
        [Unicode(false)]
        public string HownerId { get; set; } = null!;
        [Column("HOwnerName")]
        [StringLength(255)]
        [Unicode(false)]
        public string HownerName { get; set; } = null!;

        [InverseProperty("Howner")]
        public virtual ICollection<HighwayMaster> HighwayMasters { get; set; }
    }
}
