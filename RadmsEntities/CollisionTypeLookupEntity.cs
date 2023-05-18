using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class CollisionTypeLookupEntity
    {

        public int CollisionTypeId { get; set; }

        public string CollisionTypeName { get; set; } = null!;

        public CollisionTypeLookupEntity()
        {

        }

        //blic virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
        public CollisionTypeLookupEntity(CollisionTypeLookup model)
        {
            this.CollisionTypeId = model.CollisionTypeId;
            this.CollisionTypeName = model.CollisionTypeName;

        }
        public T MapToModel<T>() where T : class
        {
            CollisionTypeLookup model = new CollisionTypeLookup();
            model.CollisionTypeId = this.CollisionTypeId;
            model.CollisionTypeName = this.CollisionTypeName;
            return model as T;
        }

    }
}
