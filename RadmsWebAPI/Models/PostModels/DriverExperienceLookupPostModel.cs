using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class DriverExperienceLookupPostModel
    {
        public int DriverExperienceId { get; set; }

        public string DriverExperienceName { get; set; } = null!;
        public DriverExperienceLookupPostModel()
        {

        }
        public DriverExperienceLookupPostModel(DriverExperienceLookupEntity model)
        {
            this.DriverExperienceId = model.DriverExperienceId;
            this.DriverExperienceName = model.DriverExperienceName;
            
        }
        public T MapToViewEntity<T>() where T : class
        {
            DriverExperienceLookupEntity entity = new DriverExperienceLookupEntity();
            entity.DriverExperienceId = this.DriverExperienceId;
            entity.DriverExperienceName = this.DriverExperienceName;


            return entity as T;
        }
    }
}
