using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class HighwayOwnerMasterEntity
    {
        public HighwayOwnerMasterEntity()
        {
       //   HighwayMasters = new HashSet<HighwayMasterEntity>();
        }


        public string HownerId { get; set; } = null!;

        public string HownerName { get; set; } = null!;
        public HighwayOwnerMasterEntity(HighwayMaster model)
        {
            this.HownerId = model.HownerId;
          //this.HownerName = model.HownerName;
        }
        //public virtual ICollection<HighwayMasterEntity> HighwayMasters { get; set; }
    }
}
