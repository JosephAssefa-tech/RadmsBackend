using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class PoliceStationMasterViewModel
    {
        public string Psid { get; set; } = null!;

        public string Psname { get; set; } = null!;

       // public int? SubCityId { get; set; }

      //   public int? WoredaId { get; set; }

        public virtual SubCityMasterViewModel? SubCity { get; set; }

        public virtual WoredaMasterViewModel? Woreda { get; set; }
        public PoliceStationMasterViewModel()
        {

        }
        public PoliceStationMasterViewModel(PoliceStationMasterEntity entity)
        {
            this.Psid = entity.Psid;
            this.Psname = entity.Psname;
         //   this.SubCity = new SubCityMasterViewModel(entity.SubCity);
         //   this.Woreda = new WoredaMasterViewModel(entity.Woreda);

        }
        public T MapToViewEntity<T>() where T : class
        {
            PoliceStationMasterEntity entity = new PoliceStationMasterEntity();
            entity.Psid = this.Psid;
            entity.Psname = this.Psname;
         //   entity.WoredaId = this.Woreda.WoredaId;
         //   entity.SubCityId = this.SubCity.SubCityId;


            return entity as T;


        }
    }
}
