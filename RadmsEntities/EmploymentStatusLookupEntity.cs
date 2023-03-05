using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class EmploymentStatusLookupEntity
    {
         public  EmploymentStatusLookupEntity()
        {

         //   VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();

        }

        public int EmploymentStatusId { get; set; }

        public string EmploymentStatusName { get; set; } = null!;

      //  public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
      public EmploymentStatusLookupEntity(EmploymentStatusLookup model)
        {
            this.EmploymentStatusId=model.EmploymentStatusId;
            this.EmploymentStatusName = model.EmploymentStatusName;

        }
        public T MapToModel<T>() where T : class
        {
            EmploymentStatusLookup model = new EmploymentStatusLookup();
            model.EmploymentStatusId = this.EmploymentStatusId;
            model.EmploymentStatusName = this.EmploymentStatusName;
            return model as T;

        }

    }
}
