using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class ZoneMasterViewModel
    {

        public int ZoneId { get; set; }

        public string ZoneName { get; set; } = null!;

    //    public int? RegionId { get; set; }

        public virtual RegionMasterViewModel? Region { get; set; }

        public ZoneMasterViewModel()
        {

        }
        public ZoneMasterViewModel(ZoneMasterEntity entity)
        {
            this.ZoneId = entity.ZoneId;
            this.ZoneName = entity.ZoneName;
            this.Region = new RegionMasterViewModel
            {
                RegionName = entity.Region.RegionName,
                // other mapped properties
            };

        }
        public T MapToViewEntity<T>() where T : class
        {
            ZoneMasterEntity entity = new ZoneMasterEntity();
            entity.ZoneId = ZoneId;
            entity.ZoneName = ZoneName;
         //   entity.RegionId = this.Region.RegionId;

            return entity as T;

        }
    }
}
