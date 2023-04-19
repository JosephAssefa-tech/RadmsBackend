using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class VictimTypeLookupEntity
    {
        public VictimTypeLookupEntity()
        {
          //  VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }


        public int VictimTypeId { get; set; }

        public string VictimType { get; set; } = null!;


        //    public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public VictimTypeLookupEntity(VictimTypeLookup model)
        {
            this.VictimTypeId = model.VictimTypeId;
            this.VictimType = model.VictimType;
         
        }
        public T MapToModel<T>() where T : class
        {
            VictimTypeLookup model = new VictimTypeLookup();
            model.VictimTypeId = this.VictimTypeId;
            model.VictimType = this.VictimType;
            return model as T;
        }

    }
}
