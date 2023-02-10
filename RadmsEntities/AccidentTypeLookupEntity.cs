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
    }
}
