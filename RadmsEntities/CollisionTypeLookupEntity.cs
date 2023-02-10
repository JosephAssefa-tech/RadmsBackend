using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class CollisionTypeLookupEntity
    {

        public int CollisionTypeId { get; set; }

        public string CollisionTypeName { get; set; } = null!;

        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
    }
}
