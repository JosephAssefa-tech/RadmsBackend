using RadmsDataModels.Modelss;
using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class WoredaMasterViewModel
    {
        public int WoredaId { get; set; }

        public string WoredaName { get; set; } = null!;

        //  public int? ZoneId { get; set; }

        public virtual ZoneMasterViewModel? Zone { get; set; }

        public WoredaMasterViewModel()
        {

        }
        public WoredaMasterViewModel(WoredaMasterEntity entity)
        {
            this.WoredaId = entity.WoredaId;
            this.WoredaName = entity.WoredaName;
       //     this.Zone = new ZoneMasterViewModel(entity.Zone);

        }
        public T MapToViewEntity<T>() where T : class
        {
            WoredaMasterEntity entity = new WoredaMasterEntity();
            entity.WoredaId = this.WoredaId;
            entity.WoredaName = this.WoredaName;
            //model.ZoneId = this.Zone.;
            return entity as T;
        }
    }
}
