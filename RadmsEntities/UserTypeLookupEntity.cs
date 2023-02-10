using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class UserTypeLookupEntity
    {
        public UserTypeLookupEntity()
        {
            UserRoleTransactions = new HashSet<UserRoleTransactionEntity>();
        }

        public int UserTypeId { get; set; }

        public string UserTypeName { get; set; } = null!;


        public virtual ICollection<UserRoleTransactionEntity> UserRoleTransactions { get; set; }

    }
}
