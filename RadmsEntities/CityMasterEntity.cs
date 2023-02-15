using RadmsDataModels.Models;
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

        public CityMasterEntity()
        {

        }
        public CityMasterEntity(CityMaster model)
        {
            this.CityId = model.CityId;
            this.CityName = model.CityName;
            this.Woreda = new WoredaMasterEntity(model.Woreda);

        }


        //public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        //public virtual ICollection<SubCityMasterEntity> SubCityMasters { get; set; }
        public T MapToModel<T>() where T : class
        {
            CityMaster model = new CityMaster();
            model.CityId = this.CityId;
            model.CityName = this.CityName;
            model.WoredaId = this.Woreda.WoredaId;
            return model as T;
        }
    }
}
