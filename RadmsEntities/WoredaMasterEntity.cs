using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class WoredaMasterEntity
    {
        public WoredaMasterEntity()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
            CityMasters = new HashSet<CityMasterEntity>();
            PoliceStationMasters = new HashSet<PoliceStationMasterEntity>();
        }


        public int WoredaId { get; set; }
   
        public string WoredaName { get; set; } = null!;

        public int? ZoneId { get; set; }

        public virtual ZoneMasterEntity? Zone { get; set; }
  
        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
   
        public virtual ICollection<CityMasterEntity> CityMasters { get; set; }

        public virtual ICollection<PoliceStationMasterEntity> PoliceStationMasters { get; set; }

    }
}
