using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class LicenceLevelLookupEntity
    {
        public LicenceLevelLookupEntity()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int LeveloflicenceId { get; set; }

        public string LeveloflicenceName { get; set; } = null!;


        public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

    }
}
