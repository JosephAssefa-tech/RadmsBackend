using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class VehicleOwnershipLookupViewModel
    {
        public int VehicleOwnershipId { get; set; }

        public string VehicleOwnershipName { get; set; } = null!;
        public VehicleOwnershipLookupViewModel()
        {

        }
        public VehicleOwnershipLookupViewModel(VehicleOwnershipLookupEntity entity)
        {
            this.VehicleOwnershipId = entity.VehicleOwnershipId;
            this.VehicleOwnershipName = entity.VehicleOwnershipName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            VehicleOwnershipLookupEntity entity = new VehicleOwnershipLookupEntity();
            entity.VehicleOwnershipId = this.VehicleOwnershipId;
            entity.VehicleOwnershipName = this.VehicleOwnershipName;
            return entity as T;
        }
    }
}
