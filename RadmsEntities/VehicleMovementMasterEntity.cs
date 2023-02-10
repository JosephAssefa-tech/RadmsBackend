using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VehicleMovementMasterEntity
    {
        public VehicleMovementMasterEntity()
        {
            VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int VehicleMovementId { get; set; }

        public string VehicleMovementMasterName { get; set; } = null!;

 
        public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

    }
}
