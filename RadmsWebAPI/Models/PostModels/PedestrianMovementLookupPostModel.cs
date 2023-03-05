using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class PedestrianMovementLookupPostModel
    {
        public PedestrianMovementLookupPostModel()
        {
            //   VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }


        public int PedestrianMovementId { get; set; }

        public string PedestrianMovementName { get; set; } = null!;


        //  public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public PedestrianMovementLookupPostModel(PedestrianMovementLookupEntity entity)
        {
            this.PedestrianMovementId = entity.PedestrianMovementId;
            this.PedestrianMovementName = entity.PedestrianMovementName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            PedestrianMovementLookupEntity model = new PedestrianMovementLookupEntity();
            model.PedestrianMovementId = this.PedestrianMovementId;
            model.PedestrianMovementName = this.PedestrianMovementName;
            return model as T;
        }
    }
}
