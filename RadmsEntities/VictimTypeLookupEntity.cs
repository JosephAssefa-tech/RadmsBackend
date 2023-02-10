using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VictimTypeLookupEntity
    {
        public VictimTypeLookupEntity()
        {
            VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }


        public int VictimTypeId { get; set; }

        public string VictimType { get; set; } = null!;

 
        public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }

    }
}
