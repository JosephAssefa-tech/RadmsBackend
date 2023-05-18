using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("WeatherConditionTypeLookup")]
    public partial class WeatherConditionTypeLookup
    {
        public WeatherConditionTypeLookup()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransaction>();
        }

        [Key]
        [Column("WeatherCondID")]
        public int WeatherCondId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string WeatherCondName { get; set; } = null!;
        [StringLength(255)]
        public string? WeatherCondNameAm { get; set; }
        [StringLength(255)]
        public string? WeatherCondNameOr { get; set; }
        [StringLength(255)]
        public string? WeatherCondNameTi { get; set; }
        [StringLength(255)]
        public string? WeatherCondNameAf { get; set; }
        [StringLength(255)]
        public string? WeatherCondNameSo { get; set; }

        [InverseProperty("WeatherCond")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
