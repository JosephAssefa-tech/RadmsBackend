using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class SubCityMasterPostModel
    {
      // public int SubCityId { get; set; }

        public string SubCityName { get; set; } = null!;

        public int? CityId { get; set; }

 
        public string? SubCityNameAm { get; set; }

        public string? SubCityNameOr { get; set; }

        public string? SubCityNameTi { get; set; }
    
        public string? SubCityNameAf { get; set; }

        public string? SubCityNameSo { get; set; }

        // public virtual CityMasterPostModel? City { get; set; }


        public SubCityMasterPostModel()
        {

        }
        public SubCityMasterPostModel(SubCityMasterEntity entity)
        {
        // this.SubCityId=entity.SubCityId;
            this.SubCityName = entity.SubCityName;
            this.CityId = entity.CityId;
            this.SubCityNameAm = entity.SubCityNameAm;
            this.SubCityNameOr = entity.SubCityNameOr;
            this.SubCityNameAf = entity.SubCityNameAf;
            this.SubCityNameSo = entity.SubCityNameSo;
            this.SubCityNameTi=entity.SubCityNameTi;



        }
        public T MapToViewEntity<T>() where T : class
        {
            SubCityMasterEntity entity = new SubCityMasterEntity();
           // entity.SubCityId = this.SubCityId;
            entity.SubCityName = this.SubCityName;
            entity.CityId = this.CityId;
            entity.SubCityNameAm = this.SubCityNameAm;
            entity.SubCityNameOr = this.SubCityNameOr;
            entity.SubCityNameAf = this.SubCityNameAf;
            entity.SubCityNameSo = this.SubCityNameSo;
            entity.SubCityNameTi = this.SubCityNameTi;


           // entity.Region = this.Region.MapToViewEntity<RegionMasterEntity>(); ;
            return entity as T;


        }
    }
}
