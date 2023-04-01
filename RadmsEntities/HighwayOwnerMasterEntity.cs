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
        public HighwayOwnerMasterEntity(HighwayOwnerMaster model)
        {
            this.HownerId = model.HownerId;
            this.HownerName = model.HownerName;
        }
        //public virtual ICollection<HighwayMasterEntity> HighwayMasters { get; set; }
        public T MapToModel<T>() where T : class
        {
            HighwayOwnerMaster model = new HighwayOwnerMaster();
            model.HownerId = this.HownerId;
            model.HownerName = this.HownerName;
            return model as T;
        }
    }
}
