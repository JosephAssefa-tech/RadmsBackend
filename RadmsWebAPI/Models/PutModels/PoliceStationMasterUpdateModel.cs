using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class PoliceStationMasterUpdateModel
    {
        public string Psid { get; set; } = null!;

        public string Psname { get; set; } = null!;

        public int? SubCityId { get; set; }

        public int? WoredaId { get; set; }

        public virtual SubCityMasterUpdateModel? SubCity { get; set; }

        public virtual WoredaMasterUpdateModel? Woreda { get; set; }
        public PoliceStationMasterUpdateModel()
        {

        }
        public PoliceStationMasterUpdateModel(PoliceStationMasterEntity entity)
        {

            this.Psid = entity.Psid;
            this.Psname = entity.Psname;
            //this.SubCityId = entity.SubCityId;
            Woreda = new WoredaMasterUpdateModel(entity.Woreda);
            SubCity = new SubCityMasterUpdateModel(entity.SubCity);
        }
        public T MapToViewEntity<T>() where T : class
        {
            PoliceStationMasterEntity entity = new PoliceStationMasterEntity();
            entity.Psid = this.Psid;
            entity.Psname = this.Psname;

            return entity as T;


        }
    }
}
