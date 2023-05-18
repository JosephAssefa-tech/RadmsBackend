using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class KebeleMasterEntity
    {

        public int KebeleId { get; set; }
        public string KebeleName { get; set; } = null!;
        public KebeleMasterEntity()
        {

        }
        public KebeleMasterEntity(KebeleMaster model)
        {
            this.KebeleId = model.KebeleId;
            this.KebeleName = model.KebeleName;

        }
    }
}
