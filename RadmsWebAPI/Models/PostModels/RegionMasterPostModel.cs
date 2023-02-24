using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class RegionMasterPostModel
    {
        public int RegionId { get; set; }

        public string RegionName { get; set; } = null!;
        public RegionMasterPostModel()
        {

        }
        public RegionMasterPostModel(RegionMasterEntity entity)
        {
            this.RegionId = entity.RegionId;
            this.RegionName = entity.RegionName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            RegionMasterEntity entity = new RegionMasterEntity();
            entity.RegionId = this.RegionId;
            entity.RegionName = this.RegionName;
            return entity as T;


        }

    }
}
