using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class DrivingLicenceCatagoryLookupEntity
    {

        public int DrivingLicenceCatagoryId { get; set; }

        public string DrivingLicenceCatagoryName { get; set; } = null!;

        public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
    }
}
