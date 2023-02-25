using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class VictimMovementMasterPostModel
    {
        public VictimMovementMasterPostModel()
        {
            //   VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }


        public int VictimMovementId { get; set; }

        public string VictimMovementType { get; set; } = null!;


        //   public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public VictimMovementMasterPostModel(VictimMovementMasterEntity entity)
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
