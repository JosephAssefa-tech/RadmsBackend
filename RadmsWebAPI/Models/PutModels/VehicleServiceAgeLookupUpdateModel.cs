using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class VehicleServiceAgeLookupUpdateModel
    {
        public VehicleServiceAgeLookupUpdateModel()
        {
            //   VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();

        }


        public int VehicleServiceAgeId { get; set; }

        public string VehicleServiceName { get; set; } = null!;

        //  public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

        public VehicleServiceAgeLookupUpdateModel(VehicleServiceAgeLookupEntity model)
        {
            this.VehicleServiceAgeId = model.VehicleServiceAgeId;
            this.VehicleServiceName = model.VehicleServiceName;
            //   VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();

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
