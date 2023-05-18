using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class EducationLevelLookupEntity
    {

        public int EducationLevelId { get; set; }

        public string EducationLevelName { get; set; } = null!;

        public EducationLevelLookupEntity()
        {

        }
        public EducationLevelLookupEntity(EducationLevelLookup entity)
        {
            this.EducationLevelId = entity.EducationLevelId;
            this.EducationLevelName = entity.EducationLevelName;

        }

        //public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public T MapToModel<T>() where T : class
        {
            EducationLevelLookup model = new EducationLevelLookup();
            model.EducationLevelId = this.EducationLevelId;
            model.EducationLevelName = this.EducationLevelName;
            return model as T;

        }

    }
}
