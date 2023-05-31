using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class ZoneMasterUpdateModel
    {

       

        public string ZoneName { get; set; } = null!;
        public string? ZoneNameAm { get; set; }

        public string? ZoneNameOr { get; set; }

        public string? ZoneNameTi { get; set; }

        public string? ZoneNameAf { get; set; }

        public string? ZoneNameSo { get; set; }


        public int? RegionId { get; set; }

        public ZoneMasterUpdateModel()
        {

        }
        public ZoneMasterUpdateModel(ZoneMasterEntity entity)
        {
            this.ZoneName = entity.ZoneName;
            this.ZoneNameAm = entity.ZoneNameAm;
            this.ZoneNameOr = entity.ZoneNameOr;
            this.ZoneNameAf = entity.ZoneNameAf;
            this.ZoneNameSo = entity.ZoneNameSo;
            
            

        }
        public T MapToViewEntity<T>() where T : class
        {
            ZoneMasterEntity entity = new ZoneMasterEntity();
            entity.ZoneName = this.ZoneName;
            entity.ZoneNameAm = this.ZoneNameAm;
            entity.ZoneNameOr = this.ZoneNameOr;
            entity.ZoneNameAf = this.ZoneNameAf;
            entity.ZoneNameSo = this.ZoneNameSo;
            entity.RegionId = this.RegionId;
                
            return entity as T;


        }


    }
}
