using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class DriverExperienceLookupViewModel
    {
        public int DriverExperienceId { get; set; }

        public string DriverExperienceName { get; set; } = null!;

        public DriverExperienceLookupViewModel()
        {

        }
        public DriverExperienceLookupViewModel(DriverExperienceLookupEntity entity)
        {
            this.DriverExperienceId = entity.DriverExperienceId;
            this.DriverExperienceName = entity.DriverExperienceName;

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
