using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class LandmarkTypeLookupUpdateModel
    {
        public int LandmarkTypeId { get; set; }

        public string LandmarkName { get; set; } = null!;

        public LandmarkTypeLookupUpdateModel()
        {

        }
        public LandmarkTypeLookupUpdateModel(LandmarkTypeLookupEntity entity)
        {
            this.LandmarkTypeId = entity.LandmarkTypeId;
            this.LandmarkName = entity.LandmarkName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            LandmarkTypeLookupEntity model = new LandmarkTypeLookupEntity();
            model.LandmarkTypeId = this.LandmarkTypeId;
            model.LandmarkName = this.LandmarkName;
            //model.JunctionNoOfRoads = this.JunctionNoOfRoads;
            return model as T;
        }
    }
}
