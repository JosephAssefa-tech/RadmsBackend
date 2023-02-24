using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class LightConditionLookupPostModel
    {
        public int LightConditionId { get; set; }

        public string LightConditionName { get; set; } = null!;

        public LightConditionLookupPostModel()
        {
            this.LightConditionId = 0;
        }
        public LightConditionLookupPostModel(LightConditionLookupEntity entity)
        {
            this.LightConditionId = entity.LightConditionId;
            this.LightConditionName = entity.LightConditionName;
        }
        public T MapToViewEntity<T>() where T : class
        {
            LightConditionLookupEntity model = new LightConditionLookupEntity();
            model.LightConditionId = this.LightConditionId;
            model.LightConditionName = this.LightConditionName;

            return model as T;
        }
    }
}
