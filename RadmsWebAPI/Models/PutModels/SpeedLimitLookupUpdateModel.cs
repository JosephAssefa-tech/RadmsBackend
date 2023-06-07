using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class SpeedLimitLookupUpdateModel
    {

        public int SpeedLimitId { get; set; }

        public string SpeedLimitName { get; set; } = null!;

        public SpeedLimitLookupUpdateModel()
        {

        }
        public SpeedLimitLookupUpdateModel(SpeedLimitLookupEntity entity)
        {
            this.SpeedLimitId = entity.SpeedLimitId;
            this.SpeedLimitName = entity.SpeedLimitName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            SpeedLimitLookupEntity entity = new SpeedLimitLookupEntity();
            entity.SpeedLimitId = this.SpeedLimitId;
            entity.SpeedLimitName = this.SpeedLimitName;
           // entity.Region = this.Region.MapToViewEntity<RegionMasterEntity>(); ;
            return entity as T;


        }

    }
}