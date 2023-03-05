using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class DrivingLicenceCatagoryLookupEntity
    {

        public int DrivingLicenceCatagoryId { get; set; }

        public string DrivingLicenceCatagoryName { get; set; } = null!;
        public DrivingLicenceCatagoryLookupEntity()
        {

        }


        //   public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public DrivingLicenceCatagoryLookupEntity(DrivingLicenceCatagoryLookup model)
        {
            this.DrivingLicenceCatagoryId = model.DrivingLicenceCatagoryId;
            this.DrivingLicenceCatagoryName = model.DrivingLicenceCatagoryName;


        }
        public T MapToModel<T>() where T : class
        {
            DrivingLicenceCatagoryLookup model = new DrivingLicenceCatagoryLookup();
            model.DrivingLicenceCatagoryId = this.DrivingLicenceCatagoryId;
            model.DrivingLicenceCatagoryName = this.DrivingLicenceCatagoryName;
            return model as T;

        }
    }
}
