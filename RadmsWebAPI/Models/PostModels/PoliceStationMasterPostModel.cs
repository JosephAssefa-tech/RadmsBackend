using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class PoliceStationMasterPostModel
    {
        public string Psid { get; set; } = null!;

        public string Psname { get; set; } = null!;

        public int? SubCityId { get; set; }

        public int? WoredaId { get; set; }

        public virtual SubCityMasterPostModel? SubCity { get; set; }

        public virtual WoredaMasterPostModel? Woreda { get; set; }
        public PoliceStationMasterPostModel()
        {

        }
        public PoliceStationMasterPostModel(PoliceStationMasterEntity entity)
        {

            this.Psid = entity.Psid;
            this.Psname = entity.Psname;
            //this.SubCityId = entity.SubCityId;
            Woreda = new WoredaMasterPostModel(entity.Woreda);
            SubCity = new SubCityMasterPostModel(entity.SubCity);
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
