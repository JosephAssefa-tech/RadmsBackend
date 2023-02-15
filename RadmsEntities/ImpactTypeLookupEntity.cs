using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class ImpactTypeLookupEntity
    {
        public ImpactTypeLookupEntity()
        {
   //       AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }


        public int ImpactTypeId { get; set; }

        public string ImpactTypeName { get; set; } = null!;

        public ImpactTypeLookupEntity(ImpactTypeLookup model)
        {
            this.ImpactTypeId= model.ImpactTypeId;  
            this.ImpactTypeName=model.ImpactTypeName; 
        }
        //    public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

    }
}
