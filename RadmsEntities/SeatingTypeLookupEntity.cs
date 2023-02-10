using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class SeatingTypeLookupEntity
    {
        public SeatingTypeLookupEntity()
        {
            VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }

        public int SeatingTypeId { get; set; }

        public string SeatingTypeName { get; set; } = null!;


        public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }

    }
}
