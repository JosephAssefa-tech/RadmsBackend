using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class SubCityMasterViewModel
    {
        public int SubCityId { get; set; }

        public string SubCityName { get; set; } = null!;

      //  public int? CityId { get; set; }

        public virtual CityMasterViewModel? City { get; set; }
        public SubCityMasterViewModel()
        {

        }
        public SubCityMasterViewModel(SubCityMasterEntity entity)
        {
            this.SubCityId = entity.SubCityId;
            this.SubCityName = entity.SubCityName;
            City = new CityMasterViewModel
            {
                CityName = entity.City.CityName
            };
        }
        public T MapToViewEntity<T>() where T : class
        {
            SubCityMasterEntity entity = new SubCityMasterEntity();
            entity.SubCityId = this.SubCityId;
            entity.SubCityName = this.SubCityName;
            entity.CityId = this.City.CityId;

            return entity as T;

        }

    }

}
