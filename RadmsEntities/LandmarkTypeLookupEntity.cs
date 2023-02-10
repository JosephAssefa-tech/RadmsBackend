using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class LandmarkTypeLookupEntity
    {
        public LandmarkTypeLookupEntity()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }

        public int LandmarkTypeId { get; set; }

        public string LandmarkName { get; set; } = null!;

        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

    }
}
