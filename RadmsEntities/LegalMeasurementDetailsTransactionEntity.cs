using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class LegalMeasurementDetailsTransactionEntity
    {
        public LegalMeasurementDetailsTransactionEntity()
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

        public virtual AccidentDetailsTransactionEntity? Accident { get; set; }

        public virtual VictimDetailsTransactionEntity? Victim { get; set; }
        public LegalMeasurementDetailsTransactionEntity(LegalMeasurementDetailsTransaction model)

        {
            this.IsSuspended = model.IsSuspended;
            this.IsunderInvestigation = model.IsunderInvestigation;
            this.IsDeadFile = model.IsDeadFile;
            this.IsRemand = model.IsRemand;
            this.IsReleaseFree = model.IsReleaseFree;
            this.Imprisonment = model.Imprisonment;
            this.MoneyDesposit = model.MoneyDesposit;

            this.Accident = new AccidentDetailsTransactionEntity(model.Accident);
            this.Victim = new VictimDetailsTransactionEntity(model.Victim);

        }
        public T MapToModel<T>() where T : class
        {

            LegalMeasurementDetailsTransaction model = new LegalMeasurementDetailsTransaction();
            model.IsSuspended = this.IsSuspended;
            model.IsunderInvestigation = this.IsunderInvestigation;
            model.IsDeadFile = this.IsDeadFile;
            model.IsRemand = this.IsRemand;
            model.IsReleaseFree = this.IsReleaseFree;
            model.Imprisonment = this.Imprisonment;
            model.MoneyDesposit = this.MoneyDesposit;

            model.AccidentId = this.Accident.AccidentId;
            model.VictimId = this.Victim.VictimId;
            return model as T;

        }
 }   }

