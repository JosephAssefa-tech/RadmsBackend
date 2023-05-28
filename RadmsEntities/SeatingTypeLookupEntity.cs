using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class SeatingTypeLookupEntity
    {
        public SeatingTypeLookupEntity()
        {
          //  VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }

        public int SeatingTypeId { get; set; }

        public string SeatingTypeName { get; set; } = null!;


        //  public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public SeatingTypeLookupEntity(SeatingTypeLookup model)
        {
            this.SeatingTypeId = model.SeatingTypeId;
            this.SeatingTypeName = model.SeatingTypeName;
     
        }
        public T MapToModel<T>() where T : class
        {
            SeatingTypeLookup model = new SeatingTypeLookup();
            model.SeatingTypeId = this.SeatingTypeId;
            model.SeatingTypeName = this.SeatingTypeName;
            return model as T;
        }

    }
}
