using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class WoredaMasterPostModel
    {


        public string WoredaName { get; set; } = null!;

          public int? ZoneId { get; set; }

       // public virtual ZoneMasterPostModel? Zone { get; set; }

        public WoredaMasterPostModel()
        {

        }
        public WoredaMasterPostModel(WoredaMasterEntity entity)
        {
            this.WoredaName = entity.WoredaName;
            this.ZoneId = entity.ZoneId;

        }
        public T MapToViewEntity<T>() where T : class
        {
            WoredaMasterEntity entity = new WoredaMasterEntity();
            entity.WoredaName = this.WoredaName;
            entity.ZoneId = this.ZoneId;
            return entity as T;
        }
    }
}
