using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VechicleMasterEntity
    {
        public VechicleMasterEntity()
        {
            // VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int VehicleId { get; set; }

        public string VehicleName { get; set; } = null!;

        //  public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public VechicleMasterEntity(VechicleMaster model)
        {
            this.VehicleId = model.VehicleId;
            this.VehicleName = model.VehicleName;

        }
        public T MapToModel<T>() where T : class
        {


            VechicleMaster model = new VechicleMaster();
            model.VehicleId = this.VehicleId;
            model.VehicleName = this.VehicleName;

            return model as T;

        }
    }
}
