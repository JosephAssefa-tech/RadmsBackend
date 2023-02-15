using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class ZoneMasterEntity
    {
        public ZoneMasterEntity()
        {
     //     AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
     //     WoredaMasters = new HashSet<WoredaMasterEntity>();
        }


        public int ZoneId { get; set; }

        public string ZoneName { get; set; } = null!;

        public int? RegionId { get; set; }

        public virtual RegionMasterEntity? Region { get; set; }

        public ZoneMasterEntity(ZoneMaster model)
        {
            this.ZoneId = model.ZoneId;
            this.ZoneName = model.ZoneName;
            this.RegionId = model.RegionId;
            this.Region = new RegionMasterEntity(model.Region);


        }
        //    public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        //    public virtual ICollection<WoredaMasterEntity> WoredaMasters { get; set; }

    }
}
