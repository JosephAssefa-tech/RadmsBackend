using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class WoredaMasterPostModel
    {
        public int WoredaId { get; set; }

        public string WoredaName { get; set; } = null!;

        //  public int? ZoneId { get; set; }

        public virtual ZoneMasterPostModel? Zone { get; set; }

        public WoredaMasterPostModel()
        {

        }
        public WoredaMasterPostModel(WoredaMasterEntity entity)
        {
            this.WoredaName = entity.WoredaName;
            this.WoredaId = entity.WoredaId;
           this.Zone= new ZoneMasterPostModel(entity.Zone);

        }
        public T MapToViewEntity<T>() where T : class
        {
            WoredaMasterEntity entity = new WoredaMasterEntity();
            entity.WoredaId = this.WoredaId;
            entity.WoredaName = this.WoredaName;
            entity.Zone = this.Zone.MapToViewEntity<ZoneMasterEntity>(); ;
            return entity as T;
        }
    }
}
