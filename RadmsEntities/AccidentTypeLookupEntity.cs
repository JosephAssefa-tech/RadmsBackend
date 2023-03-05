using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class AccidentTypeLookupEntity
    {
        public AccidentTypeLookupEntity()
        {
           // AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }

        public int AccidentTypeId { get; set; }

        public string AccidentType { get; set; } = null!;


        //public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }


        public AccidentTypeLookupEntity(AccidentTypeLookup model)
        {
            this.AccidentTypeId = model.AccidentTypeId;
            this.AccidentType = model.AccidentType;

        }
        public T MapToModel<T>() where T : class
        {
            AccidentTypeLookup model = new AccidentTypeLookup();
            model.AccidentTypeId = this.AccidentTypeId;
            model.AccidentType = this.AccidentType;
            return model as T;
        }
    }
}
