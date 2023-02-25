using RadmsDataModels.Models;
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
         //   VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int VehicleDefectId { get; set; }

        public string VehicleDefectName { get; set; } = null!;

        //  public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public VehicleDefectLookupEntity(VehicleDefectLookup model)
        {
            this.VehicleDefectId = model.VehicleDefectId;
            this.VehicleDefectName = model.VehicleDefectName;
        }
        public T MapToModel<T>() where T : class
        {

            VehicleDefectLookup model = new VehicleDefectLookup();
            model.VehicleDefectId = this.VehicleDefectId;
            model.VehicleDefectName = this.VehicleDefectName;
            return model as T;

        }

    }
}
