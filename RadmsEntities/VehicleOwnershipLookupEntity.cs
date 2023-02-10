using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VehicleOwnershipLookupEntity
    {
        public VehicleOwnershipLookupEntity()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }

        public int VehicleOwnershipId { get; set; }

        public string VehicleOwnershipName { get; set; } = null!;


        public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

    }
}
