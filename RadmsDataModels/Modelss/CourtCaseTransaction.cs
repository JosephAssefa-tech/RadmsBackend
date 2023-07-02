using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RadmsDataModels.Modelss
{
    [Table("CourtCaseTransaction")]
    public class CourtCaseTransaction
    {
        public CourtCaseTransaction()
        {
     
        }
        [Key]
        [Column("ID", TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [Column("AccidentID")]
        public int AccidentID { get; set; }
        [Column("CourtChargeID")]
        public int CourtChargeID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ChargeDate { get; set; }
        [Column("PenaltyAmount")]
        [StringLength(255)]
        [Unicode(false)]
        public decimal PenaltyAmount { get; set; } 
        [Column("ImprisonmentDays")]
        [StringLength(255)]
        [Unicode(false)]
        public int ImprisonmentDays { get; set; } 


        
    }
}
