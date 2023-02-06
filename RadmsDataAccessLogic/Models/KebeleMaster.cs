using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
{
    [Table("KebeleMaster")]
    public partial class KebeleMaster
    {
        [Key]
        [Column("KebeleID")]
        public int KebeleId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string KebeleName { get; set; } = null!;
    }
}
