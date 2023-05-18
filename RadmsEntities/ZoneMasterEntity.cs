using RadmsDataModels.Modelss;
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
          //  this.Region = new RegionMasterEntity(model.Region);


        }
        //    public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        //    public virtual ICollection<WoredaMasterEntity> WoredaMasters { get; set; }
        public T MapToModel<T>() where T : class
        {
            ZoneMaster model = new ZoneMaster();
            model.ZoneId = this.ZoneId;
            model.ZoneName = this.ZoneName;
           // model.RegionId = this.Region.RegionId;

            return model as T;
        }

    }
}
