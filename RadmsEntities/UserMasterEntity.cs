using RadmsDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadmsEntities
{
    public class UserMasterEntity
    {
        public UserMasterEntity()
        {
     //     AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
     //     AuditTrailTransactions = new HashSet<AuditTrailTransactionEntity>();
        }

        public int UserId { get; set; }

        public string UserPassword { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public DateTime DateTimeUser { get; set; }

        public int? OrganizationId { get; set; }

        public virtual OrganizationMasterEntity? Organization { get; set; }

        public UserMasterEntity(UserMaster model)
        {
            this.UserId = model.UserId;
            this.UserPassword=model.UserPassword;
            this.UserName=model.UserName;
            this.DateTimeUser = model.DateTimeUser;
            this.OrganizationId = model.OrganizationId;
           this.Organization = new OrganizationMasterEntity(model.Organization);


        }
        //[InverseProperty("User")]
        //  public virtual ICollection<AccidentDetailsTransactionEntity> AccidentDetailsTransactions { get; set; }
        //[InverseProperty("User")]
        //  public virtual ICollection<AuditTrailTransactionEntity> AuditTrailTransactions { get; set; }
        public T MapToModel<T>() where T : class
        {
            UserMaster model = new UserMaster();
            model.UserId = this.UserId;
            model.UserPassword = this.UserPassword;
            model.UserName = this.UserName;
            model.DateTimeUser = this.DateTimeUser;
            model.OrganizationId = this.OrganizationId;

            return model as T;
        }

    }
}
