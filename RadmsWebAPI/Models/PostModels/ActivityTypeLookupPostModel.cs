using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class ActivityTypeLookupPostModel
    {

        public int ActivityId { get; set; }


        public string ActivityName { get; set; } = null!;
        public ActivityTypeLookupPostModel()
        {

        }
        public ActivityTypeLookupPostModel(ActivityTypeLookupEntity entity)
        {
            this.ActivityId = entity.ActivityId;
            this.ActivityName = entity.ActivityName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            ActivityTypeLookupEntity entity = new ActivityTypeLookupEntity();
            entity.ActivityId = this.ActivityId;
            entity.ActivityName = this.ActivityName;


            return entity as T;

        }
    }
}
