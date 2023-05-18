using RadmsDataModels.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class FormMasterEntity
    {
        public FormMasterEntity()
        {
          //  AuditTrailTransactions = new HashSet<AuditTrailTransactionEntity>();
          //  UserRoleTransactions = new HashSet<UserRoleTransactionEntity>();
        }

        public int FormId { get; set; }

        public string FormUrl { get; set; } = null!;

        //  public virtual ICollection<AuditTrailTransactionEntity> AuditTrailTransactions { get; set; }
        //  public virtual ICollection<UserRoleTransactionEntity> UserRoleTransactions { get; set; }
       public FormMasterEntity(FormMaster model)
        {
            this.FormId=model.FormId;
            this.FormUrl=model.FormUrl;

        }
        public T MapToModel<T>() where T : class
        {
            FormMaster model = new FormMaster();
            model.FormId = this.FormId;
            model.FormUrl = this.FormUrl;
            model.FormId = model.FormId;
            //model.RecordId = this.re;
            return model as T;
        }

    }
}
