using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class ImpactTypeLookupEntity
    {
        public ImpactTypeLookupEntity()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }


        public int ImpactTypeId { get; set; }

        public string ImpactTypeName { get; set; } = null!;


        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

    }
}
