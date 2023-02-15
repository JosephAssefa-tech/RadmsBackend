using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class RoadCarriagewayTypeLookupEntity
    {
        public RoadCarriagewayTypeLookupEntity()
        {
      //    AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }

        public int RoadCarriagewayId { get; set; }

        public string RoadCarriagewayName { get; set; } = null!;
        public RoadCarriagewayTypeLookupEntity(RoadCarriagewayTypeLookup model)
        {
            this.RoadCarriagewayId = model.RoadCarriagewayId;       
            this.RoadCarriagewayName=model.RoadCarriagewayName;


        }

        //     public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
    }
}
