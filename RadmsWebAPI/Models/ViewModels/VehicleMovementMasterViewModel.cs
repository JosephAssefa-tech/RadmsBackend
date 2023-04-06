using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class VehicleMovementMasterViewModel
    {
        public int VehicleMovementId { get; set; }

        public string VehicleMovementMasterName { get; set; } = null!;


        public VehicleMovementMasterViewModel()
        {

        }
        public VehicleMovementMasterViewModel(VehicleMovementMasterEntity entity)
        {
            this.VehicleMovementId = entity.VehicleMovementId;
            this.VehicleMovementMasterName = entity.VehicleMovementMasterName;
        }
        public T MapToViewEntity<T>() where T : class
        {
            VehicleMovementMasterEntity entity = new VehicleMovementMasterEntity();
            entity.VehicleMovementId = this.VehicleMovementId;
            entity.VehicleMovementMasterName = this.VehicleMovementMasterName;
            return entity as T;
        }

    }
}
