using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class SpeedLimitLookupEntity
    {
        public SpeedLimitLookupEntity()
        {
      //    AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }


        public int SpeedLimitId { get; set; }

        public string SpeedLimitName { get; set; } = null!;
        public SpeedLimitLookupEntity(SpeedLimitLookup model)
        {
            this.SpeedLimitId = model.SpeedLimitId;
            this.SpeedLimitName = model.SpeedLimitName;  
          
        }
        //  public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
        public T MapToModel<T>() where T : class
        {
            SpeedLimitLookup model = new SpeedLimitLookup();
            model.SpeedLimitId = this.SpeedLimitId;
            model.SpeedLimitName = this.SpeedLimitName;
            return model as T;
        }

    }
}
