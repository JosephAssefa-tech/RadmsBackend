using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class RegionMasterEntity
    {
        public RegionMasterEntity()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
            ZoneMasters = new HashSet<ZoneMasterEntity>();
        }


        public int RegionId { get; set; }

        public string RegionName { get; set; } = null!;

        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
 
        public virtual ICollection<ZoneMasterEntity> ZoneMasters { get; set; }

    }
}
