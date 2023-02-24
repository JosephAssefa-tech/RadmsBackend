using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class AuditTrailTransactionEntity
    {

        public string RecordId { get; set; } = null!;
        public int? UserId { get; set; }
        public int? ActivityId { get; set; }
        public DateTime DateTimeAudit { get; set; }
        public int? FormId { get; set; }
        public virtual ActivityTypeLookupEntity? Activity { get; set; }
        public virtual FormMasterEntity? Form { get; set; }

        public virtual UserMasterEntity? User { get; set; }
        public AuditTrailTransactionEntity()
        {

        }
        public AuditTrailTransactionEntity(AuditTrailTransaction model)
        {
            this.RecordId = model.RecordId;
            this.UserId = model.UserId;
            this.ActivityId = model.ActivityId;
            this.DateTimeAudit = model.DateTimeAudit;
            this.FormId = model.FormId;
            this.Activity = new ActivityTypeLookupEntity(model.Activity);
            this.Form = new FormMasterEntity(model.Form);
            this.User = new UserMasterEntity(model.User);


        }

        public T MapToModel<T>() where T : class
        {
            AuditTrailTransaction model = new AuditTrailTransaction();
            model.RecordId = this.RecordId;
            model.UserId = this.UserId;
            model.ActivityId = this.ActivityId;
            model.DateTimeAudit = this.DateTimeAudit;
            model.FormId =model.FormId;
            //model.RecordId = this.re;
            return model as T;
        }

    }
}
