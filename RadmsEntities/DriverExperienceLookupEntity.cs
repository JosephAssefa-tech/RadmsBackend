using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class DriverExperienceLookupEntity
    {

        public int DriverExperienceId { get; set; }

        public string DriverExperienceName { get; set; } = null!;


        public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

    }
}
