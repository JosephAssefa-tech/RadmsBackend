using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class WeatherConditionTypeLookupPostModel
    {
        public int WeatherCondId { get; set; }

        public string WeatherCondName { get; set; } = null!;
        public WeatherConditionTypeLookupPostModel()
        {

        }
        public WeatherConditionTypeLookupPostModel(WeatherConditionTypeLookupEntity entity)
        {
            this.WeatherCondId = entity.WeatherCondId;
            this.WeatherCondName = entity.WeatherCondName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            WeatherConditionTypeLookupEntity entity = new WeatherConditionTypeLookupEntity();
            entity.WeatherCondId = this.WeatherCondId;
            entity.WeatherCondName = this.WeatherCondName;
            //entity.Region = this.Region.MapToViewEntity<RegionMasterEntity>(); ;
            return entity as T;


        }

    }
}
