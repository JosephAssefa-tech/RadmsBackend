using RadmsDataModels.Models;
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
           // VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int VehicleMovementId { get; set; }

        public string VehicleMovementMasterName { get; set; } = null!;


        //  public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public VehicleMovementMasterEntity(VehicleMovementMaster model)
        {
            // VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
            this.VehicleMovementId = model.VehicleMovementId;
            this.VehicleMovementMasterName = model.VehicleMovementMasterName;
        }
        public T MapToModel<T>() where T : class
        {

            VehicleMovementMaster model = new VehicleMovementMaster();
            model.VehicleMovementId = this.VehicleMovementId;
            model.VehicleMovementMasterName = this.VehicleMovementMasterName;
            return model as T;

        }
    }
}
