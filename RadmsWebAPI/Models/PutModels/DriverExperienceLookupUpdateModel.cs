using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class DriverExperienceLookupUpdateModel
    {
        public int DriverExperienceId { get; set; }

        public string DriverExperienceName { get; set; } = null!;
        public DriverExperienceLookupUpdateModel()
        {

        }
        public DriverExperienceLookupUpdateModel(DriverExperienceLookupEntity model)
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
