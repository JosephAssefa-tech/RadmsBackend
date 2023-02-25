using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class VehicleRelationLookupPostModel
    {
        public VehicleRelationLookupPostModel()
        {
            //   VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int VehicleRelationId { get; set; }

        public string VehicleRelationName { get; set; } = null!;


        //   public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public VehicleRelationLookupPostModel(VehicleRelationLookupEntity model)
        {
            this.VehicleRelationId = model.VehicleRelationId;
            this.VehicleRelationName = model.VehicleRelationName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            VehicleRelationLookupEntity entity = new VehicleRelationLookupEntity();
            entity.VehicleRelationId = this.VehicleRelationId;
            entity.VehicleRelationName = this.VehicleRelationName;

            return entity as T;
        }
    }
}
