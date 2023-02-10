using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class RoadSurfaceConditionLookupEntity
    {
        public RoadSurfaceConditionLookupEntity()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }


        public int RoadSurfaceId { get; set; }

        public string RoadSurfaceName { get; set; } = null!;


        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

    }
}
