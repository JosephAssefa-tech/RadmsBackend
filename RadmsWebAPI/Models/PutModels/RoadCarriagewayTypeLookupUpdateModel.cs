using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class RoadCarriagewayTypeLookupUpdateModel
    {

        public int RoadCarriagewayId { get; set; }

        public string RoadCarriagewayName { get; set; } = null!;
        public RoadCarriagewayTypeLookupUpdateModel()
        {

        }
        public RoadCarriagewayTypeLookupUpdateModel(RoadCarriagewayTypeLookupEntity entity)
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
