using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class PedestrianMovementLookupEntity
    {
        public PedestrianMovementLookupEntity()
        {
            VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }


        public int PedestrianMovementId { get; set; }

        public string PedestrianMovementName { get; set; } = null!;

 
        public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }

    }
}
