using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class AirConditionTypeLookupEntity
    {
        public AirConditionTypeLookupEntity()
        {
            //AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }

        public int AirConditionId { get; set; }
        public string AirConditionName { get; set; } = null!;

        //public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

    }
}
