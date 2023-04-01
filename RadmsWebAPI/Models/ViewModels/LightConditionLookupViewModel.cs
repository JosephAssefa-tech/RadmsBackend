using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class LightConditionLookupViewModel
    {
        public int LightConditionId { get; set; }

        public string LightConditionName { get; set; } = null!;

        public LightConditionLookupViewModel()
        {
            this.LightConditionId = 0;
        }
        public LightConditionLookupViewModel(LightConditionLookupEntity entity)
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
