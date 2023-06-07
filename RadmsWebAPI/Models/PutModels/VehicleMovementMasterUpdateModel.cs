using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class VehicleMovementMasterPutModel
    {
        public VehicleMovementMasterPutModel()
        {
            // VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int VehicleMovementId { get; set; }

        public string VehicleMovementMasterName { get; set; } = null!;


        //  public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public VehicleMovementMasterPutModel(VehicleMovementMasterEntity model)
        {
            // VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
            this.VehicleMovementId = model.VehicleMovementId;
            this.VehicleMovementMasterName = model.VehicleMovementMasterName;
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
