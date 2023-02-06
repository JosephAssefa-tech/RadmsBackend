using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataAccessLogic.Models
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

        [InverseProperty("WeatherCond")]
        public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }
    }
}
