using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class AuditTrailTransactionEntity
    {

        public string RecordId { get; set; } = null!;
        public int? UserId { get; set; }
        public int? ActivityId { get; set; }
        public DateTime DateTimeAudit { get; set; }
        public int? FormId { get; set; }
        public virtual ActivityTypeLookupEntity? Activity { get; set; }
        public virtual FormMasterEntity? Form { get; set; }

        public virtual UserMasterEntity? User { get; set; }
    }
}
