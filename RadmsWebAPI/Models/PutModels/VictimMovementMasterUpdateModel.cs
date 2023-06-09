using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class VictimMovementMasterUpdateModel
    {
        public VictimMovementMasterUpdateModel()
        {
            //   VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }


        public int VictimMovementId { get; set; }

        public string VictimMovementType { get; set; } = null!;


        //   public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public VictimMovementMasterUpdateModel(VictimMovementMasterEntity entity)
        {

            this.VictimMovementId = entity.VictimMovementId;
            this.VictimMovementType = entity.VictimMovementType;
        }
        public T MapToViewEntity<T>() where T : class
        {
            VictimMovementMasterEntity entity = new VictimMovementMasterEntity();
            entity.VictimMovementId = this.VictimMovementId;
            entity.VictimMovementId = this.VictimMovementId;


            return entity as T;

        }
    }
}
