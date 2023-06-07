using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class LightConditionLookupPutModel
    {
        public int LightConditionId { get; set; }

        public string LightConditionName { get; set; } = null!;

        public LightConditionLookupPutModel()
        {
            this.LightConditionId = 0;
        }
        public LightConditionLookupPutModel(LightConditionLookupEntity entity)
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
