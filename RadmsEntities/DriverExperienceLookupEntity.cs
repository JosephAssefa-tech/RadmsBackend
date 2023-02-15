using RadmsDataModels.Models;
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
        public DriverExperienceLookupEntity()
        {

        }
        public DriverExperienceLookupEntity(DriverExperienceLookup model)
        {
            this.DriverExperienceId=model.DriverExperienceId;
            this.DriverExperienceName = model.DriverExperienceName;


        }

        //    public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

    }
}
