using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class VictimTypeLookupUpdateModel
    {
        public VictimTypeLookupUpdateModel()
        {
            //  VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }


        public int VictimTypeId { get; set; }

        public string VictimType { get; set; } = null!;


        //    public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public VictimTypeLookupUpdateModel(VictimTypeLookupEntity entity)
        {
            this.VictimType = entity.VictimType;
            this.VictimType = entity.VictimType;

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