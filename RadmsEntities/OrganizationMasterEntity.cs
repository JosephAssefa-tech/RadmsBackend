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
            UserMasters = new HashSet<UserMasterEntity>();
        }


        public int OrganizationId { get; set; }

        public string OrganizationName { get; set; } = null!;

        public virtual ICollection<UserMasterEntity> UserMasters { get; set; }

    }
}
