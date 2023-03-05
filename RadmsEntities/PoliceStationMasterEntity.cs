using RadmsDataModels.Models;
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
     //     AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }

        public string Psid { get; set; } = null!;

        public string Psname { get; set; } = null!;

        public int? SubCityId { get; set; }

        public int? WoredaId { get; set; }

        public virtual SubCityMasterEntity? SubCity { get; set; }

        public virtual WoredaMasterEntity? Woreda { get; set; }

        public PoliceStationMasterEntity(PoliceStationMaster model)
        {
            this.Psid = model.Psid;
            this.Psname = model.Psname;
            this.SubCityId = model.SubCityId;
            this.WoredaId = model.WoredaId;
            this.SubCity = new SubCityMasterEntity(model.SubCity);
            this.Woreda = new WoredaMasterEntity(model.Woreda);



        }
        //     public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
        public T MapToModel<T>() where T : class
        {
            PoliceStationMaster model = new PoliceStationMaster();
            model.Psid = this.Psid;
            model.Psname = this.Psname;
            model.SubCityId = this.SubCityId;
            model.WoredaId = this.WoredaId;
            return model as T;
        }

    }
}
