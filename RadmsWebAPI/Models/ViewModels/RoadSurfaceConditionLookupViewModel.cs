using RadmsDataModels.Modelss;
using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class RoadSurfaceConditionLookupViewModel
    {
        public int RoadSurfaceId { get; set; }

        public string RoadSurfaceName { get; set; } = null!;
        public RoadSurfaceConditionLookupViewModel()
        {

        }
        public RoadSurfaceConditionLookupViewModel(RoadSurfaceConditionLookupEntity entity)
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
