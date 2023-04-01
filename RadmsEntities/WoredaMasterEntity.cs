using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class WoredaMasterEntity
    {

        public int WoredaId { get; set; }

        public string WoredaName { get; set; } = null!;

        //  public int? ZoneId { get; set; }

        public virtual ZoneMasterEntity? Zone { get; set; }
        public WoredaMasterEntity()
        {
      //    AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
      //    CityMasters = new HashSet<CityMasterEntity>();
      //    PoliceStationMasters = new HashSet<PoliceStationMasterEntity>();
        }



        public WoredaMasterEntity(WoredaMaster model)
        {
            this.WoredaId=model.WoredaId;
            this.WoredaName = model.WoredaName;
          //  this.ZoneId = model.ZoneId;
            this.Zone = new ZoneMasterEntity(model.Zone);
        }
        public T MapToModel<T>() where T : class
        {
            WoredaMaster model = new WoredaMaster();
            model.WoredaId = this.WoredaId;
            model.WoredaName = this.WoredaName;
            model.ZoneId = this.Zone.ZoneId;
            return model as T;
        }

        //   public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        //     public virtual ICollection<CityMasterEntity> CityMasters { get; set; }

        //   public virtual ICollection<PoliceStationMasterEntity> PoliceStationMasters { get; set; }

    }
}
