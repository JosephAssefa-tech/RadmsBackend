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
        public int SeverityId { get; set; }
        public string SeverityType { get; set; } = null!;
        public SeverityLevelLookupEntity(SeverityLevelLookup model)
        {
            this.SeverityId = model.SeverityId;
            this.SeverityType=model.SeverityType;
        }
        // public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
        public T MapToModel<T>() where T : class
        {
            SeverityLevelLookup model = new SeverityLevelLookup();
            model.SeverityType = this.SeverityType;
            model.SeverityId = this.SeverityId;
          //  model.PavementName = this.PavementName;
            return model as T;
        }

    }
}
