using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class ZoneMasterPostModel
    {
        public ZoneMasterPostModel()
        {

        }
       // public int ZoneId { get; set; }

        public string ZoneName { get; set; } = null!;

        public int? RegionId { get; set; }
        public string? ZoneNameAm { get; set; }

        public string? ZoneNameOr { get; set; }

        public string? ZoneNameTi { get; set; }

        public string? ZoneNameAf { get; set; }

        public string? ZoneNameSo { get; set; }

        //  public virtual RegionMasterPostModel? Region { get; set; }

        public ZoneMasterPostModel(ZoneMasterEntity entity)
        {
           // this.ZoneId = entity.ZoneId;
            this.ZoneName = entity.ZoneName;
            this.RegionId = entity.RegionId;
            this.ZoneNameAm = entity.ZoneNameAm;
            this.ZoneNameOr = entity.ZoneNameOr;
            this.ZoneNameAf = entity.ZoneNameAf;
            this.ZoneNameTi = entity.ZoneNameTi;
            this.ZoneNameSo = entity.ZoneNameSo;




        }
        public T MapToViewEntity<T>() where T : class
        {
            ZoneMasterEntity entity = new ZoneMasterEntity();
           // entity.ZoneId = this.ZoneId;
            entity.ZoneName = this.ZoneName;
            entity.RegionId = this.RegionId;
            entity.ZoneNameAm = this.ZoneNameAm;
            entity.ZoneNameOr = this.ZoneNameOr;
            entity.ZoneNameAf = this.ZoneNameAf;
            entity.ZoneNameSo = this.ZoneNameSo;
            entity.ZoneNameTi = this.ZoneNameTi;

            return entity as T;


        }

    }
}
