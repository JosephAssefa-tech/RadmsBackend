using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class PavementTypeLookupEntity
    {
        public PavementTypeLookupEntity()
        {
 //         AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }


        public int PavementTypeId { get; set; }

        public string PavementName { get; set; } = null!;
        public PavementTypeLookupEntity(PavementTypeLookup model)
        {
          this.PavementTypeId = model.PavementTypeId;
          this.PavementName=model.PavementName;
        }

        //    public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
        public T MapToModel<T>() where T : class
        {
            PavementTypeLookup model = new PavementTypeLookup();
            model.PavementTypeId = this.PavementTypeId;
            model.PavementName = this.PavementName;
            return model as T;
        }
    }
}
