using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class LegalMeasurementDetailsTransactionEntity
    {

        public decimal? AccidentId { get; set; }

        public string? VictimId { get; set; }
        public bool? IsSuspended { get; set; }

        public bool? IsunderInvestigation { get; set; }
        public bool? IsDeadFile { get; set; }
        public bool? IsRemand { get; set; }
        public bool? IsReleaseFree { get; set; }

        public decimal? Imprisonment { get; set; }

        public decimal? MoneyDesposit { get; set; }

        public virtual AccidentDetailsTransactionEntity? Accident { get; set; }

        public virtual VictimDetailsTransactionEntity? Victim { get; set; }

    }
}
