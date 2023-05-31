using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class RegionMasterUpdateModel
    {
        //public int RegionId { get; set; }
        public string RegionName { get; set; } = null!;


        public string? RegionNameAm { get; set; }

        public string? RegionNameOr { get; set; }

        public string? RegionNameTi { get; set; }

        public string? RegionNameAf { get; set; }

        public string? RegionNameSo { get; set; }
        public RegionMasterUpdateModel()
        {

        }
        public RegionMasterUpdateModel(RegionMasterEntity entity)
        {
            this.RegionName = entity.RegionName;
            this.RegionNameAm = entity.RegionNameAm;
            this.RegionNameOr = entity.RegionNameOr;
            this.RegionNameTi = entity.RegionNameTi;
            this.RegionNameAf = entity.RegionNameAf;
            this.RegionNameSo = entity.RegionNameSo;
        }
        public T MapToViewEntity<T>() where T : class
        {
            RegionMasterEntity entity = new RegionMasterEntity();

            entity.RegionName = this.RegionName;
            entity.RegionNameAm = this.RegionNameAm;
            entity.RegionNameOr = this.RegionNameOr;
            entity.RegionNameTi = this.RegionNameTi;
            entity.RegionNameAf = this.RegionNameAf;
            entity.RegionNameSo = this.RegionNameSo;
            return entity as T;


        }
    }
}
