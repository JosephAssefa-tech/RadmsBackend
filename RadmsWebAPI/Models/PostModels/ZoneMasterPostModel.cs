using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class ZoneMasterPostModel
    {
        public ZoneMasterPostModel()
        {

        }
        public int ZoneId { get; set; }

        public string ZoneName { get; set; } = null!;

       // public int? RegionId { get; set; }

        public virtual RegionMasterPostModel? Region { get; set; }
    
        public ZoneMasterPostModel(ZoneMasterEntity entity)
        {
            this.ZoneId = entity.ZoneId;
            this.ZoneName = entity.ZoneName;
            this.Region = new RegionMasterPostModel(entity.Region);
        }
        public T MapToViewEntity<T>() where T : class
        {
            ZoneMasterEntity entity = new ZoneMasterEntity();
            entity.ZoneId = this.ZoneId;
            entity.ZoneName = this.ZoneName;
            entity.Region = this.Region.MapToViewEntity<RegionMasterEntity>(); ;
            return entity as T;


        }

    }
}
