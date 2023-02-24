using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class SubCityMasterPostModel
    {
        public int SubCityId { get; set; }

        public string SubCityName { get; set; } = null!;

        public int? CityId { get; set; }

        public virtual CityMasterPostModel? City { get; set; }


        public SubCityMasterPostModel()
        {

        }
        public SubCityMasterPostModel(SubCityMasterEntity entity)
        {
         this.SubCityId=entity.SubCityId;
            this.SubCityName = entity.SubCityName;
            this.City = new CityMasterPostModel(entity.City);
        }
        public T MapToViewEntity<T>() where T : class
        {
            SubCityMasterEntity entity = new SubCityMasterEntity();
            entity.SubCityId = this.SubCityId;
            entity.SubCityName = this.SubCityName;
           // entity.Region = this.Region.MapToViewEntity<RegionMasterEntity>(); ;
            return entity as T;


        }
    }
}
