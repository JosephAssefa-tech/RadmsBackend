using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VehicleRelationLookupEntity
    {
        public VehicleRelationLookupEntity()
        {
         //   VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int VehicleRelationId { get; set; }

        public string VehicleRelationName { get; set; } = null!;


        //   public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public VehicleRelationLookupEntity(VehicleRelationLookup model)
        {
            this.VehicleRelationId = model.VehicleRelationId;
            this.VehicleRelationName = model.VehicleRelationName;
           
        }
        public T MapToModel<T>() where T : class
        {

            VehicleRelationLookup model = new VehicleRelationLookup();
            model.VehicleRelationId = this.VehicleRelationId;
            model.VehicleRelationName = this.VehicleRelationName;
            return model as T;

        }

    }
}
