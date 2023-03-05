using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class LightConditionLookupEntity
    {
        public LightConditionLookupEntity()
        {
   //       AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }

        public int LightConditionId { get; set; }

        public string LightConditionName { get; set; } = null!;

        public LightConditionLookupEntity(LightConditionLookup model)
        {
            this.LightConditionId = model.LightConditionId;
            this.LightConditionName = model.LightConditionName;
        }
        //   public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
        public T MapToModel<T>() where T : class
        {
            LightConditionLookup model = new LightConditionLookup();
            model.LightConditionId = this.LightConditionId;
            model.LightConditionName = this.LightConditionName;
    
            return model as T;
        }

    }
}
