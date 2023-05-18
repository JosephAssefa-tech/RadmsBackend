using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
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
        [StringLength(255)]
        public string? KebeleNameAm { get; set; }
        [StringLength(255)]
        public string? KebeleNameOr { get; set; }
        [StringLength(255)]
        public string? KebeleNameTi { get; set; }
        [StringLength(255)]
        public string? KebeleNameAf { get; set; }
        [StringLength(255)]
        public string? KebeleNameSo { get; set; }
    }
}
