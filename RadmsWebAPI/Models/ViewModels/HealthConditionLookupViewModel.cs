using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class HealthConditionLookupViewModel
    {
        public int HealthConditionId { get; set; }

        public string HealthConditionName { get; set; } = null!;

        //  public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public HealthConditionLookupViewModel(HealthConditionLookupEntity entity)
        {
            this.HealthConditionId = entity.HealthConditionId;
            this.HealthConditionName = entity.HealthConditionName;
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
