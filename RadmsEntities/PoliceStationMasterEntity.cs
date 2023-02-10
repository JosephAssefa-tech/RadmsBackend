using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class PoliceStationMasterEntity
    {
        public PoliceStationMasterEntity()
        {
            AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }

        public string Psid { get; set; } = null!;

        public string Psname { get; set; } = null!;

        public int? SubCityId { get; set; }

        public int? WoredaId { get; set; }

        public virtual SubCityMasterEntity? SubCity { get; set; }

        public virtual WoredaMasterEntity? Woreda { get; set; }

        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

    }
}
