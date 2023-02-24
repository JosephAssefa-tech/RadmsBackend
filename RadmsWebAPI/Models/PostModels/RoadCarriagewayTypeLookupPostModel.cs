using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class RoadCarriagewayTypeLookupPostModel
    {

        public int RoadCarriagewayId { get; set; }

        public string RoadCarriagewayName { get; set; } = null!;
        public RoadCarriagewayTypeLookupPostModel()
        {

        }
        public RoadCarriagewayTypeLookupPostModel(RoadCarriagewayTypeLookupEntity entity)
        {
            this.RoadCarriagewayId = entity.RoadCarriagewayId;
            this.RoadCarriagewayName = entity.RoadCarriagewayName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            RoadCarriagewayTypeLookupEntity entity = new RoadCarriagewayTypeLookupEntity();
            entity.RoadCarriagewayId = this.RoadCarriagewayId;
            entity.RoadCarriagewayName = this.RoadCarriagewayName;
            return entity as T;

        }
    }
}
