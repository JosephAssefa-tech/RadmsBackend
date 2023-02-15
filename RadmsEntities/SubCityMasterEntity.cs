using RadmsDataModels.Models;
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

        public SubCityMasterEntity(SubCityMaster model)
        {
            this.SubCityId = model.SubCityId;
            this.CityId = model.CityId;
            this.SubCityName = model.SubCityName;
            this.City = new CityMasterEntity(model.City);


        }

        // public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }

        // public virtual ICollection<PoliceStationMasterEntity> PoliceStationMasters { get; set; }

    }
}
