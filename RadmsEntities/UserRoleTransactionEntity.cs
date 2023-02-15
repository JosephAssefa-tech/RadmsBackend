using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class UserRoleTransactionEntity
    {

        public int DepartmentTypeId { get; set; }

        public int? UserTypeId { get; set; }

        public int? FormId { get; set; }


        public virtual FormMasterEntity? Form { get; set; }

        public virtual UserTypeLookupEntity? UserType { get; set; }

    }
}
