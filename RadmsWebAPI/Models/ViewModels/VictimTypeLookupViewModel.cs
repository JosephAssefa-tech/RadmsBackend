using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class VictimTypeLookupViewModel
    {
        public int VictimTypeId { get; set; }

        public string VictimType { get; set; } = null!;


        //    public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public VictimTypeLookupViewModel(VictimTypeLookupEntity entity)
        {
            this.VictimType = entity.VictimType;
            this.VictimTypeId = entity.VictimTypeId;

        }
        public T MapToViewEntity<T>() where T : class
        {
            VictimTypeLookupEntity entity = new VictimTypeLookupEntity();
            entity.VictimTypeId = this.VictimTypeId;
            entity.VictimType = this.VictimType;
            return entity as T;
        }
    }
}
