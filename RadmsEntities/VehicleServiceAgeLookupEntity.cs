using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VehicleServiceAgeLookupEntity
    {
        public VehicleServiceAgeLookupEntity()
        {
            //   VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();

        }


        public int VehicleServiceAgeId { get; set; }

        public string VehicleServiceName { get; set; } = null!;

        //  public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

        public VehicleServiceAgeLookupEntity(VehicleServiceAgeLookup model)
        {
            this.VehicleServiceAgeId = model.VehicleServiceAgeId;
            this.VehicleServiceName = model.VehicleServiceName;
            //   VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();

        }
        public T MapToModel<T>() where T : class
        {

            VehicleServiceAgeLookup model = new VehicleServiceAgeLookup();
            model.VehicleServiceAgeId = this.VehicleServiceAgeId;
            model.VehicleServiceName = this.VehicleServiceName;
            return model as T;

        }
    }
}
