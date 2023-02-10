using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class HealthConditionLookupEntity
    {
        public HealthConditionLookupEntity()
        {
            VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }

        public int HealthConditionId { get; set; }

        public string HealthConditionName { get; set; } = null!;

        public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }

    }
}
