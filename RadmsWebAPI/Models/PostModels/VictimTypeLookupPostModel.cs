using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class VictimTypeLookupPostModel
    {
        public VictimTypeLookupPostModel()
        {
            //  VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }


        public int VictimTypeId { get; set; }

        public string VictimType { get; set; } = null!;


        //    public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public VictimTypeLookupPostModel(VictimTypeLookupEntity entity)
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