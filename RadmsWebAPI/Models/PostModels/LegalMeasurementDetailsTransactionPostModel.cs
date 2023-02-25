using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class LegalMeasurementDetailsTransactionPostModel
    {
        public LegalMeasurementDetailsTransactionPostModel()
        {

        }

        // public decimal? AccidentId { get; set; }

            //  public string? VictimId { get; set; }
        public bool? IsSuspended { get; set; }

        public bool? IsunderInvestigation { get; set; }
        public bool? IsDeadFile { get; set; }
        public bool? IsRemand { get; set; }
        public bool? IsReleaseFree { get; set; }

        public decimal? Imprisonment { get; set; }

        public decimal? MoneyDesposit { get; set; }

        public virtual AccidentDetailsTransactionPostModel? Accident { get; set; }

        public virtual VictimDetailsTransactionPostModel? Victim { get; set; }


        public LegalMeasurementDetailsTransactionPostModel(LegalMeasurementDetailsTransactionEntity entity)
        {
            this.IsSuspended = entity.IsSuspended;
            this.IsunderInvestigation = entity.IsunderInvestigation;
            this.IsDeadFile = entity.IsDeadFile;
            this.IsRemand = entity.IsRemand;
            this.IsReleaseFree = entity.IsReleaseFree;
            this.Imprisonment = entity.Imprisonment;
            this.MoneyDesposit = entity.MoneyDesposit;

            this.Accident = new AccidentDetailsTransactionPostModel(entity.Accident);
            this.Victim = new VictimDetailsTransactionPostModel(entity.Victim);

        }

        public T MapToViewEntity<T>() where T : class
        {
            LegalMeasurementDetailsTransactionEntity entity = new LegalMeasurementDetailsTransactionEntity();
            entity.IsSuspended = this.IsSuspended;
            entity.IsunderInvestigation = this.IsunderInvestigation;
            entity.IsDeadFile = this.IsDeadFile;
            entity.IsRemand = this.IsRemand;
            entity.IsReleaseFree = this.IsReleaseFree;
            entity.Imprisonment = this.Imprisonment;
            entity.MoneyDesposit = this.MoneyDesposit;

            entity.Accident = this.Accident.MapToViewEntity<AccidentDetailsTransactionEntity>();
            entity.Victim = this.Victim.MapToViewEntity<VictimDetailsTransactionEntity>();

            return entity as T;

        }

    }
}



