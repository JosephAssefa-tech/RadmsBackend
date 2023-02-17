using RadmsDataModels.Models;
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
            this.Zone = new ZoneMasterViewModel(entity.Zone);

        }
        public T MapToModel<T>() where T : class
        {
            WoredaMaster model = new WoredaMaster();
            model.WoredaId = this.WoredaId;
            model.WoredaName = this.WoredaName;
            //model.ZoneId = this.Zone.;
            return model as T;
        }
    }
}
