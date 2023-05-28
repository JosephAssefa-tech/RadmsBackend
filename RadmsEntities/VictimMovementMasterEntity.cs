using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VictimMovementMasterEntity
    {
        public VictimMovementMasterEntity()
        {
         //   VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }


        public int VictimMovementId { get; set; }
     
        public string VictimMovementType { get; set; } = null!;


        //   public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public VictimMovementMasterEntity(VictimMovementMaster model)
        {
           
           this.VictimMovementId = model.VictimMovementId;
            this.VictimMovementType = model.VictimMovementType;
        }
        public T MapToModel<T>() where T : class
        {
            VictimMovementMaster model = new VictimMovementMaster();
            model.VictimMovementId = this.VictimMovementId;
            model.VictimMovementType = this.VictimMovementType;
            return model as T;
        }

    }
}
