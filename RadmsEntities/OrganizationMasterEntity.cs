using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class OrganizationMasterEntity
    {
        public OrganizationMasterEntity()
        {
            //   UserMasters = new HashSet<UserMasterEntity>();
        }


        public int OrganizationId { get; set; }

        public string OrganizationName { get; set; } = null!;
        public OrganizationMasterEntity(OrganizationMaster model)
        {
            this.OrganizationId = model.OrganizationId;
            this.OrganizationName = model.OrganizationName;

        }

        //   public virtual ICollection<UserMasterEntity> UserMasters { get; set; }
        public T MapToModel<T>() where T : class
        {
            OrganizationMaster model = new OrganizationMaster();
            model.OrganizationId = this.OrganizationId;
            model.OrganizationName = this.OrganizationName;
            return model as T;
        }

    }
}
