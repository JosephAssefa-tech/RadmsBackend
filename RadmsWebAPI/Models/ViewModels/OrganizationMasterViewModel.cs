using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class OrganizationMasterViewModel
    {
        public int OrganizationId { get; set; }

        public string OrganizationName { get; set; } = null!;
        public OrganizationMasterViewModel()
        {

        }
        public OrganizationMasterViewModel(OrganizationMasterEntity entity)
        {
            this.OrganizationId = entity.OrganizationId;
            this.OrganizationName = entity.OrganizationName;
        }
        public T MapToViewEntity<T>() where T : class
        {
            OrganizationMasterEntity entity = new OrganizationMasterEntity();
            entity.OrganizationId = this.OrganizationId;
            entity.OrganizationName = this.OrganizationName;
          //  entity.Region = this.Region.MapToViewEntity<RegionMasterEntity>(); ;
            return entity as T;


        }

    }
}
