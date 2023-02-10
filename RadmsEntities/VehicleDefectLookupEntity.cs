using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VehicleDefectLookupEntity
    {
        public VehicleDefectLookupEntity()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int VehicleDefectId { get; set; }

        public string VehicleDefectName { get; set; } = null!;

        public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

    }
}
