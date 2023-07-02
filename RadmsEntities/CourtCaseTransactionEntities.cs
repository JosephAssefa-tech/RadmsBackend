using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class CourtCaseTransactionEntities
    {
        public CourtCaseTransactionEntities()
        {

        }
        public int AccidentID { get; set; }
        public int CourtChargeID { get; set; }
        public DateTime ChargeDate { get; set; }
        public decimal PenaltyAmount { get; set; } 
        public int ImprisonmentDays { get; set; } 
        public CourtCaseTransactionEntities(CourtCaseTransaction model)
        {
            this.AccidentID = model.AccidentID;
            this.CourtChargeID = model.CourtChargeID;
            this.ChargeDate = model.ChargeDate;
            this.PenaltyAmount = model.PenaltyAmount;
            this.ImprisonmentDays = model.ImprisonmentDays;

   

        }
        public T MapToModel<T>() where T : class
        {
            CourtCaseTransaction model = new CourtCaseTransaction();
            model.AccidentID = this.AccidentID;
            model.CourtChargeID = this.CourtChargeID;
            model.ChargeDate = this.ChargeDate;
            model.PenaltyAmount = this.PenaltyAmount;
            model.ImprisonmentDays = this.ImprisonmentDays;
            return model as T;
        }

    }
}
