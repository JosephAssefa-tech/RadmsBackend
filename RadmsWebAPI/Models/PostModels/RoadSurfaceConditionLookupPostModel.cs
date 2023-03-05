using RadmsDataModels.Models;
using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class RoadSurfaceConditionLookupPostModel
    {
        public int RoadSurfaceId { get; set; }

        public string RoadSurfaceName { get; set; } = null!;
        public RoadSurfaceConditionLookupPostModel()
        {

        }
        public RoadSurfaceConditionLookupPostModel(RoadSurfaceConditionLookupEntity entity)
        {
            this.RoadSurfaceId = entity.RoadSurfaceId;
            this.RoadSurfaceName = entity.RoadSurfaceName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            RoadSurfaceConditionLookupEntity entity = new RoadSurfaceConditionLookupEntity();
            entity.RoadSurfaceId = this.RoadSurfaceId;
            entity.RoadSurfaceName = this.RoadSurfaceName;
            return entity as T;

        }
    }
}
