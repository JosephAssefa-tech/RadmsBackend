using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class CityMasterEntity
    {

        public int CityId { get; set; }

        public string CityName { get; set; } = null!;

        public int? WoredaId { get; set; }

        public virtual WoredaMasterEntity? Woreda { get; set; }

        public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        public virtual ICollection<SubCityMasterEntity> SubCityMasters { get; set; }
    }
}
