using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class VehicleOwnershipLookupPostModel
    {
        public VehicleOwnershipLookupPostModel()
        {
            // VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }

        public int VehicleOwnershipId { get; set; }

        public string VehicleOwnershipName { get; set; } = null!;


        //public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public VehicleOwnershipLookupPostModel(VehicleOwnershipLookupEntity model)
        {
            this.VehicleOwnershipId = model.VehicleOwnershipId;
            this.VehicleOwnershipName = model.VehicleOwnershipName;
            // VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
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
