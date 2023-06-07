using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class HealthConditionLookupUpdateModel
    {
        public HealthConditionLookupUpdateModel()
        {
            // VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }

        public int HealthConditionId { get; set; }

        public string HealthConditionName { get; set; } = null!;

        //  public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public HealthConditionLookupUpdateModel(HealthConditionLookupEntity entity)
        {
            this.HealthConditionId = entity.HealthConditionId;
            this.HealthConditionId = entity.HealthConditionId;
        }
        public T MapToViewEntity<T>() where T : class
        {
            HealthConditionLookupEntity entity = new HealthConditionLookupEntity();
            entity.HealthConditionId = this.HealthConditionId;
            entity.HealthConditionName = this.HealthConditionName;

            return entity as T;

        }
    }
}
