using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class FormMasterEntity
    {
        public FormMasterEntity()
        {
            AuditTrailTransactions = new HashSet<AuditTrailTransactionEntity>();
            UserRoleTransactions = new HashSet<UserRoleTransactionEntity>();
        }

        public int FormId { get; set; }

        public string FormUrl { get; set; } = null!;

        public virtual ICollection<AuditTrailTransactionEntity> AuditTrailTransactions { get; set; }
        public virtual ICollection<UserRoleTransactionEntity> UserRoleTransactions { get; set; }

    }
}
