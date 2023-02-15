using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class TerrainTypeLookupEntity
    {
        public TerrainTypeLookupEntity()
        {
      //    AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }

        public int TerrianTypeId { get; set; }

        public string TerrianName { get; set; } = null!;

        public TerrainTypeLookupEntity(TerrainTypeLookup model)
        {
            this.TerrianTypeId = model.TerrianTypeId;
            this.TerrianName = model.TerrianName;
          
        }
        //   public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

    }
}
