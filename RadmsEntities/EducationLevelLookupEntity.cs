using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class EducationLevelLookupEntity
    {

        public int EducationLevelId { get; set; }

        public string EducationLevelName { get; set; } = null!;


        public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

    }
}
