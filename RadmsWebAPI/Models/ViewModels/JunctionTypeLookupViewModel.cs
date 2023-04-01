using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class JunctionTypeLookupViewModel
    {
        public int JunctionTypeId { get; set; }

        public string JunctionTypeName { get; set; } = null!;
        public int JunctionNoOfRoads { get; set; }

        public JunctionTypeLookupViewModel()
        {

        }
        public JunctionTypeLookupViewModel(JunctionTypeLookupEntity entity)
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
