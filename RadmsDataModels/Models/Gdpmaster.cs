using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Models
{
    [Table("GDPMaster")]
    public partial class Gdpmaster
    {
        [Key]
        [Column("GDPID")]
        public int Gdpid { get; set; }
        [Column("GDPYear")]
        public int Gdpyear { get; set; }
        [Column("GDPValue")]
        public double Gdpvalue { get; set; }
    }
}
