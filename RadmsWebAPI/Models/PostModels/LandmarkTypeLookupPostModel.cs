using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class LandmarkTypeLookupPostModel
    {
        public int LandmarkTypeId { get; set; }

        public string LandmarkName { get; set; } = null!;

        public LandmarkTypeLookupPostModel()
        {

        }
        public LandmarkTypeLookupPostModel(LandmarkTypeLookupEntity entity)
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
