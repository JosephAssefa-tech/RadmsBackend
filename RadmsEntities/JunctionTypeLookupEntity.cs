using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class JunctionTypeLookupEntity
    {
        public JunctionTypeLookupEntity()
        {
    //      AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }

        public int JunctionTypeId { get; set; }

        public string JunctionTypeName { get; set; } = null!;
        public int JunctionNoOfRoads { get; set; }
        public JunctionTypeLookupEntity(JunctionTypeLookup model)
        {
            this.JunctionTypeId=model.JunctionTypeId;
            this.JunctionTypeName = model.JunctionTypeName;
            this.JunctionNoOfRoads=model.JunctionNoOfRoads;
           
        }

        //   public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

    }
}
