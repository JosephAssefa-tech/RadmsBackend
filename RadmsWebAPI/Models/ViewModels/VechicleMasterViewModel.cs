using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class VechicleMasterViewModel
    {
        public int VehicleId { get; set; }

        public string VehicleName { get; set; } = null!;
        public VechicleMasterViewModel()
        {

        }
        public VechicleMasterViewModel(VechicleMasterEntity entity)
        {
            this.VehicleId = entity.VehicleId;
            this.VehicleName = entity.VehicleName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            VechicleMasterEntity entity = new VechicleMasterEntity();
            entity.VehicleId = this.VehicleId;
            entity.VehicleName = this.VehicleName;
            return entity as T;


        }

    }
}
