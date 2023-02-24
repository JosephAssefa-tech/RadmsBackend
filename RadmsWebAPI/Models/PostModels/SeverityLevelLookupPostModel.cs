using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class SeverityLevelLookupPostModel
    {
        public int SeverityId { get; set; }
        public string SeverityType { get; set; } = null!;
        public SeverityLevelLookupPostModel()
        {

        }
        public SeverityLevelLookupPostModel(SeverityLevelLookupEntity entity)
        {
            this.SeverityId = entity.SeverityId;
            this.SeverityType = entity.SeverityType;


        }
        public T MapToViewEntity<T>() where T : class
        {
            SeverityLevelLookupEntity entity = new SeverityLevelLookupEntity();
            entity.SeverityId = this.SeverityId;
            entity.SeverityType = this.SeverityType;
            return entity as T;

        }

    }
}
