using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class UserMasterEntity
    {
        public UserMasterEntity()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
            AuditTrailTransactions = new HashSet<AuditTrailTransactionEntity>();
        }

        public int UserId { get; set; }

        public string UserPassword { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public DateTime DateTimeUser { get; set; }

        public int? OrganizationId { get; set; }

        public virtual OrganizationMasterEntity? Organization { get; set; }
        //[InverseProperty("User")]
        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
        //[InverseProperty("User")]
        public virtual ICollection<AuditTrailTransactionEntity> AuditTrailTransactions { get; set; }

    }
}
