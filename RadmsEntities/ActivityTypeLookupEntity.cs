using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class ActivityTypeLookupEntity
    {
        public ActivityTypeLookupEntity()
        {
            //AuditTrailTransactions = new HashSet<AuditTrailTransactionEntity>();
        }


        public int ActivityId { get; set; }


        public string ActivityName { get; set; } = null!;

        // public virtual ICollection<AuditTrailTransactionEntity> AuditTrailTransactions { get; set; }
       public ActivityTypeLookupEntity(ActivityTypeLookup model)
        {
            this.ActivityId = model.ActivityId;
            this.ActivityName=model.ActivityName;


        }

        public T MapToModel<T>() where T : class
        {
            ActivityTypeLookup model = new ActivityTypeLookup();
            model.ActivityId = this.ActivityId;
            model.ActivityName = this.ActivityName;
            return model as T;
        }


    }
}
