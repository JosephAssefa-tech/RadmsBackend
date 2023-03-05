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
           RegionId = entity.RegionId;
            RegionName = entity.RegionName;

        }
        public T MapToModel<T>() where T : class
        {
            RegionMaster model = new RegionMaster();
            model.RegionId = this.RegionId;
            model.RegionName = this.RegionName;
            //model.ZoneId = this.Zone.;
            return model as T;
        }
    }
}
