using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class VictimMovementMasterViewModel
    {
        public int VictimMovementId { get; set; }

        public string VictimMovementType { get; set; } = null!;
        public VictimMovementMasterViewModel()
        {

        }
        public VictimMovementMasterViewModel(VictimMovementMasterEntity entity)
        {
            this.VictimMovementId = entity.VictimMovementId;
            this.VictimMovementType = entity.VictimMovementType;

        }
        public T MapToViewEntity<T>() where T : class
        {
            VictimMovementMasterEntity entity = new VictimMovementMasterEntity();
            entity.VictimMovementId = this.VictimMovementId;
            entity.VictimMovementType = this.VictimMovementType;
            return entity as T;
        }
    }
}
