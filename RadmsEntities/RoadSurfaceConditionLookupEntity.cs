using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class RoadSurfaceConditionLookupEntity
    {
        public RoadSurfaceConditionLookupEntity()
        {
     //     AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }


        public int RoadSurfaceId { get; set; }

        public string RoadSurfaceName { get; set; } = null!;

        public RoadSurfaceConditionLookupEntity(RoadSurfaceConditionLookup model)
        {
       this.RoadSurfaceId=model.RoadSurfaceId;
            this.RoadSurfaceName=model.RoadSurfaceName;
        }
        // public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
        public T MapToModel<T>() where T : class
        {
            RoadSurfaceConditionLookup model = new RoadSurfaceConditionLookup();
            model.RoadSurfaceId = this.RoadSurfaceId;
            model.RoadSurfaceName = this.RoadSurfaceName;
            return model as T;
        }

    }
}
