using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class VehicleServiceAgeLookupViewModel
    {
        public int VehicleServiceAgeId { get; set; }

        public string VehicleServiceName { get; set; } = null!;
        public VehicleServiceAgeLookupViewModel()
        {

        }
        public VehicleServiceAgeLookupViewModel(VehicleServiceAgeLookupEntity entity)
        {
            this.VehicleServiceAgeId = entity.VehicleServiceAgeId;
            this.VehicleServiceName = entity.VehicleServiceName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            VehicleServiceAgeLookupEntity entity = new VehicleServiceAgeLookupEntity();
            entity.VehicleServiceAgeId = this.VehicleServiceAgeId;
            entity.VehicleServiceName = this.VehicleServiceName;
            return entity as T;
        }
    }
}
