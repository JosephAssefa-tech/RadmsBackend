using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class VehicleServiceAgeLookupPostModel
    {
        public VehicleServiceAgeLookupPostModel()
        {
            //   VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();

        }


        public int VehicleServiceAgeId { get; set; }

        public string VehicleServiceName { get; set; } = null!;

        //  public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }

        public VehicleServiceAgeLookupPostModel(VehicleServiceAgeLookupEntity model)
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
