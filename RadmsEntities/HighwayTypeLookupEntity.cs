using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class HighwayTypeLookupEntity
    {
        public HighwayTypeLookupEntity()
        {
         // AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        //  HighwayMasters = new HashSet<HighwayMasterEntity>();
        }

        public int HtypeId { get; set; }
        public string HtypeName { get; set; } = null!;

        public HighwayTypeLookupEntity(HighwayTypeLookup model)
        {
            this.HtypeId = model.HtypeId;
            this.HtypeName = model.HtypeName;

        }
        //  public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }


        public T MapToModel<T>() where T : class
        {
            HighwayTypeLookup model = new HighwayTypeLookup();
            model.HtypeId = this.HtypeId;
            model.HtypeName = this.HtypeName;
            return model as T;
        }

    }
}
