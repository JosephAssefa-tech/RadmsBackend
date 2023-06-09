using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class JunctionTypeLookupUpdateModel
    {
        public int JunctionTypeId { get; set; }

        public string JunctionTypeName { get; set; } = null!;
        public int JunctionNoOfRoads { get; set; }

        public JunctionTypeLookupUpdateModel()
        {

        }
        public JunctionTypeLookupUpdateModel(JunctionTypeLookupEntity entity)
        {
            this.JunctionTypeId = entity.JunctionTypeId;
            this.JunctionTypeName = entity.JunctionTypeName;
            this.JunctionNoOfRoads = entity.JunctionNoOfRoads;
        }
        public T MapToViewEntity<T>() where T : class
        {
            JunctionTypeLookupEntity model = new JunctionTypeLookupEntity();
            model.JunctionTypeId = this.JunctionTypeId;
            model.JunctionNoOfRoads = this.JunctionNoOfRoads;
            model.JunctionTypeName = this.JunctionTypeName;
            return model as T;
        }
    }
}
