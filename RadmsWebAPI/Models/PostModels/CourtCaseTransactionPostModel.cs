using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class CourtCaseTransactionPostModel
    {
        public CourtCaseTransactionPostModel()
        {

        }
        public int AccidentID { get; set; }
        public int CourtChargeID { get; set; }
        public DateTime ChargeDate { get; set; }
        public decimal PenaltyAmount { get; set; } 
        public int ImprisonmentDays { get; set; } 
        public CourtCaseTransactionPostModel(CourtCaseTransactionEntities model)
        {
            this.AccidentID = model.AccidentID;
            this.CourtChargeID = model.CourtChargeID;
            this.ChargeDate = model.ChargeDate;
            this.PenaltyAmount = model.PenaltyAmount;
            this.ImprisonmentDays = model.ImprisonmentDays;


        }
        public T MapToViewEntity<T>() where T : class
        {
            CourtCaseTransactionEntities model = new CourtCaseTransactionEntities();
            model.AccidentID = this.AccidentID;
            model.CourtChargeID = this.CourtChargeID;
            model.ChargeDate = this.ChargeDate;
            model.PenaltyAmount = this.PenaltyAmount;
            model.ImprisonmentDays = this.ImprisonmentDays;
            //  model.Woreda = this.Woreda.MapToViewEntity<WoredaMasterEntity>(); ;
            return model as T;
        }
    }
}
