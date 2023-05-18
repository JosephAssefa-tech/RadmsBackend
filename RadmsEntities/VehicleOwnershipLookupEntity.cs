using RadmsDataModels.Modelss;
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
           // VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }

        public int VehicleOwnershipId { get; set; }

        public string VehicleOwnershipName { get; set; } = null!;


        //public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public VehicleOwnershipLookupEntity(VehicleOwnershipLookup model)
        {
            this.VehicleOwnershipId = model.VehicleOwnershipId;
            this.VehicleOwnershipName = model.VehicleOwnershipName;
            // VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }
        public T MapToModel<T>() where T : class
        {

            VehicleOwnershipLookup model = new VehicleOwnershipLookup();
            model.VehicleOwnershipId = this.VehicleOwnershipId;
            model.VehicleOwnershipName = this.VehicleOwnershipName;
            return model as T;

        }

    }
}
