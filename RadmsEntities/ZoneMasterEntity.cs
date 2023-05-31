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
        public string? ZoneNameAm { get; set; }

        public string? ZoneNameOr { get; set; }

        public string? ZoneNameTi { get; set; }

        public string? ZoneNameAf { get; set; }

        public string? ZoneNameSo { get; set; }


        public int? RegionId { get; set; }

        public virtual RegionMasterEntity? Region { get; set; }

        public ZoneMasterEntity(ZoneMaster model)
        {
            this.ZoneId = model.ZoneId;
            this.ZoneName = model.ZoneName;
            this.RegionId = model.RegionId;
            this.Region = new RegionMasterEntity
            {
                RegionName = model.Region.RegionName,
                // other mapped properties
            };



        }
        //    public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        //    public virtual ICollection<WoredaMasterEntity> WoredaMasters { get; set; }
        public T MapToModel<T>() where T : class
        {
            ZoneMaster model = new ZoneMaster();
            model.ZoneId = this.ZoneId;
            model.ZoneName = this.ZoneName;
            model.RegionId = this.RegionId;
            model.ZoneNameAm = this.ZoneNameAm;
            model.ZoneNameOr = this.ZoneNameOr;
            model.ZoneNameAf = this.ZoneNameAf;
            model.ZoneNameSo = this.ZoneNameSo;
            model.ZoneNameTi= this.ZoneNameTi;




            return model as T;
        }

    }
}
