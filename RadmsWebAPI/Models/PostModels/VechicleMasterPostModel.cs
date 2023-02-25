using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class VechicleMasterPostModel
    {
        public VechicleMasterPostModel()
        {
            // VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int VehicleId { get; set; }

        public string VehicleName { get; set; } = null!;

        //  public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public VechicleMasterPostModel(VechicleMasterEntity model)
        {
            this.VehicleId = model.VehicleId;
            this.VehicleName = model.VehicleName;

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
