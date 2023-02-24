using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class UserMasterPostModel
    {

        public int UserId { get; set; }

        public string UserPassword { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public DateTime DateTimeUser { get; set; }

       // public int? OrganizationId { get; set; }

        public virtual OrganizationMasterPostModel? Organization { get; set; }
        public UserMasterPostModel()
        {

        }
        public UserMasterPostModel(UserMasterEntity entity)
        {
            this.UserId = entity.UserId;
            this.UserPassword=entity.UserPassword;
            this.UserName = entity.UserName;
            this.DateTimeUser = entity.DateTimeUser;
            this.Organization = new OrganizationMasterPostModel(entity.Organization);

        }
        public T MapToViewEntity<T>() where T : class
        {
            UserMasterEntity entity = new UserMasterEntity();
            entity.UserId = this.UserId;
            entity.UserPassword = this.UserPassword;
            entity.UserName = this.UserName;
            entity.DateTimeUser = this.DateTimeUser;
            //   entity.Region = this.Region.MapToViewEntity<RegionMasterEntity>(); ;
            return entity as T;


        }
    }
}
