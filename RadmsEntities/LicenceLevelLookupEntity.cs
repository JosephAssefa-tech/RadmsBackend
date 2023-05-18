using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class LicenceLevelLookupEntity
    {
        public LicenceLevelLookupEntity()
        {
          //  VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int LeveloflicenceId { get; set; }

        public string LeveloflicenceName { get; set; } = null!;


        //  public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public LicenceLevelLookupEntity(LicenceLevelLookup model)
        {
            //  VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
            this.LeveloflicenceId = model.LeveloflicenceId;
            this.LeveloflicenceName = model.LeveloflicenceName;
        }
        public T MapToModel<T>() where T : class
        {

            LicenceLevelLookup model = new LicenceLevelLookup();
            model.LeveloflicenceId = this.LeveloflicenceId;
            model.LeveloflicenceName = this.LeveloflicenceName;
            return model as T;

        }

    }
}
