using RadmsDataModels.Models;
using RadmsEntities.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class AccidentCauseLookupEntity: RadmsBaseEntity
    {


        public int AccidentCauseId { get; set; }
        public string AccidentCauseName { get; set; } = null!;
        //public virtual ICollection<AccidentDetailsTransaction> AccidentDetailsTransactions { get; set; }

        public AccidentCauseLookupEntity()
        {

        }
        public AccidentCauseLookupEntity(AccidentCauseLookup model)
        {
            this.AccidentCauseId = model.AccidentCauseId;
            this.AccidentCauseName = model.AccidentCauseName;

        }


        public T MapToModel<T>() where T : class
        {
            AccidentCauseLookup model = new AccidentCauseLookup();
            model.AccidentCauseId = this.AccidentCauseId;
            model.AccidentCauseName = this.AccidentCauseName;
            return model as T;
        }
    }
}
