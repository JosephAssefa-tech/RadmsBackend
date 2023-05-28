using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class RegionMasterEntity
    {
        public int RegionId { get; set; }

        public string RegionName { get; set; } = null!;
        public string RegionNameAm { get; set; } = null!;
        public string RegionNameOr { get; set; } = null!;
    public string RegionNameTi { get; set; } = null!;
    public string RegionNameAf { get; set; } = null!;
    public string RegionNameSo { get; set; } = null!;

    public RegionMasterEntity()
        {
   //       AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
    //      ZoneMasters = new HashSet<ZoneMasterEntity>();
        }




        public RegionMasterEntity(RegionMaster model)
        {
            this.RegionId = model.RegionId;
            this.RegionName = model.RegionName;
            this.RegionNameAm = model.RegionNameAm;
            this.RegionNameOr = model.RegionNameOr;
            this.RegionNameAf = model.RegionNameAf;
            this.RegionNameSo = model.RegionNameSo;
            this.RegionNameTi = model.RegionNameTi;

        }

        //    public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        //   public virtual ICollection<ZoneMasterEntity> ZoneMasters { get; set; }
        public T MapToModel<T>() where T : class
        {
            RegionMaster model = new RegionMaster();
            //model.RegionId = this.RegionId;
            model.RegionName = this.RegionName;
            model.RegionNameAm = this.RegionNameAm;
            model.RegionNameOr = this.RegionNameOr;
            model.RegionNameAf = this.RegionNameAf;
            model.RegionNameSo = this.RegionNameSo;
            model.RegionNameTi = this.RegionNameTi;

            return model as T;
        }

    }
}
