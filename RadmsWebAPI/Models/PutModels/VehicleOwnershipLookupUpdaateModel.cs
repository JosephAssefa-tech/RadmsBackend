using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class VehicleOwnershipLookupUpdateModel
    {
        public VehicleOwnershipLookupUpdateModel()
        {
            // VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }

        public int VehicleOwnershipId { get; set; }

        public string VehicleOwnershipName { get; set; } = null!;


        //public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public VehicleOwnershipLookupUpdateModel(VehicleOwnershipLookupEntity model)
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
