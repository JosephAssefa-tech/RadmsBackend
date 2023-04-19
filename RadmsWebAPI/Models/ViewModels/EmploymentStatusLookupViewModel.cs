using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class EmploymentStatusLookupViewModel
    {
        public int EmploymentStatusId { get; set; }

        public string EmploymentStatusName { get; set; } = null!;
        public EmploymentStatusLookupViewModel()
        {

        }
        public EmploymentStatusLookupViewModel(EmploymentStatusLookupEntity entity)
        {
            this.EmploymentStatusId = entity.EmploymentStatusId;
            this.EmploymentStatusName = entity.EmploymentStatusName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            EmploymentStatusLookupEntity entity = new EmploymentStatusLookupEntity();
            entity.EmploymentStatusId = this.EmploymentStatusId;
            entity.EmploymentStatusName = this.EmploymentStatusName;
            return entity as T;
        }
    }
}
