using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class SeverityLevelLookupEntity
    {
        public SeverityLevelLookupEntity()
        {
      //    AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }

        public string SeverityType { get; set; } = null!;
        public SeverityLevelLookupEntity(SeverityLevelLookup model)
        {
            this.SeverityType=model.SeverityType;
        }
     // public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

    }
}
