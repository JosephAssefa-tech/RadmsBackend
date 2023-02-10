using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class SubCityMasterEntity
    {
        public SubCityMasterEntity()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
            PoliceStationMasters = new HashSet<PoliceStationMasterEntity>();
        }


        public int SubCityId { get; set; }

        public string SubCityName { get; set; } = null!;

        public int? CityId { get; set; }

        public virtual CityMasterEntity? City { get; set; }

        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        public virtual ICollection<PoliceStationMasterEntity> PoliceStationMasters { get; set; }

    }
}
