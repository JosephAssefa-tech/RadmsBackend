using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class SubCityMasterEntity
    {
        public SubCityMasterEntity()
        {
    //      AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
    //      PoliceStationMasters = new HashSet<PoliceStationMasterEntity>();
        }


        public int SubCityId { get; set; }

        public string SubCityName { get; set; } = null!;

        public int? CityId { get; set; }

        public virtual CityMasterEntity? City { get; set; }
        public string? SubCityNameAm { get; set; }

        public string? SubCityNameOr { get; set; }

        public string? SubCityNameTi { get; set; }

        public string? SubCityNameAf { get; set; }

        public string? SubCityNameSo { get; set; }

        public SubCityMasterEntity(SubCityMaster model)
        {
            this.SubCityId = model.SubCityId;
            this.SubCityName = model.SubCityName;
            City = new CityMasterEntity
            {
                CityName = model.City.CityName
            };


        }

        // public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        // public virtual ICollection<PoliceStationMasterEntity> PoliceStationMasters { get; set; }
        public T MapToModel<T>() where T : class
        {
            SubCityMaster model = new SubCityMaster();
            model.SubCityId = this.SubCityId;
            model.SubCityName = this.SubCityName;
            model.SubCityNameAm = this.SubCityNameAm;
            model.SubCityNameOr = this.SubCityNameOr;
            model.SubCityNameAf = this.SubCityNameAf;
            model.SubCityNameSo = this.SubCityNameSo;
            model.SubCityNameTi = this.SubCityNameTi;
           model.CityId = this.CityId;
  


            return model as T;
        }

    }
}
