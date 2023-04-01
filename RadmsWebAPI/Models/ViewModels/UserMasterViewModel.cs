using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class UserMasterViewModel
    {

        public int UserId { get; set; }

        public string UserPassword { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public DateTime DateTimeUser { get; set; }

       // public int? OrganizationId { get; set; }

        public virtual OrganizationMasterViewModel? Organization { get; set; }
        public UserMasterViewModel()
        {

        }
        public UserMasterViewModel(UserMasterEntity entity)
        {
            this.UserId = entity.UserId;
            this.UserPassword=entity.UserPassword;
            this.UserName = entity.UserName;
            this.DateTimeUser = entity.DateTimeUser;
            this.Organization = new OrganizationMasterViewModel(entity.Organization);

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
