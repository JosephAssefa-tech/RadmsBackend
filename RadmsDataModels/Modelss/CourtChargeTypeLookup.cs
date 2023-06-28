using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsDataModels.Modelss
{
    [Table("CourtChargeTypeLookup")]
    public partial class CourtChargeTypeLookup
    {
        [Key]
        [Column("CourtChargeID")]
        public int CourtChargeID { get; set; }
        [Column("CourtChargeType")]
        public string CourtChargeType { get; set; }

    }
}
