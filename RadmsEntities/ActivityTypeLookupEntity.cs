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

    }
}
