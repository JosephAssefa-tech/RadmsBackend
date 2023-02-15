using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class EmploymentStatusLookupEntity
    {
         public  EmploymentStatusLookupEntity()
        {

            VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();

        }

        public int EmploymentStatusId { get; set; }

        public string EmploymentStatusName { get; set; } = null!;

        public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }

    }
}
