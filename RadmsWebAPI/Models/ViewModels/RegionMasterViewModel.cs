using RadmsDataModels.Models;
using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class RegionMasterViewModel
    {

        public int RegionId { get; set; }

        public string RegionName { get; set; } = null!;

        public RegionMasterViewModel()
        {

        }
        public RegionMasterViewModel(RegionMasterEntity entity)
        {
           this.RegionId = entity.RegionId;
            this.RegionName = entity.RegionName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            RegionMasterEntity entity = new RegionMasterEntity();
            entity.RegionId = this.RegionId;
            entity.RegionName = this.RegionName;
            //model.ZoneId = this.Zone.;
            return entity as T;
        }
    }
}
