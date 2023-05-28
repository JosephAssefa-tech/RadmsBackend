using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class LandmarkTypeLookupEntity
    {
        public LandmarkTypeLookupEntity()
        {
 //         AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }

        public int LandmarkTypeId { get; set; }

        public string LandmarkName { get; set; } = null!;
        public LandmarkTypeLookupEntity(LandmarkTypeLookup model)
        {
            this.LandmarkTypeId= model.LandmarkTypeId;
            this.LandmarkName=model.LandmarkName;
           
        }

        //   public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
        public T MapToModel<T>() where T : class
        {
            LandmarkTypeLookup model = new LandmarkTypeLookup();
            model.LandmarkTypeId = this.LandmarkTypeId;
            model.LandmarkName = this.LandmarkName;
            return model as T;
        }

    }
}
