using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VictimMovementMasterEntity
    {
        public VictimMovementMasterEntity()
        {
            VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }


        public int VictimMovementId { get; set; }
     
        public string VictimMovementType { get; set; } = null!;

    
        public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }

    }
}
