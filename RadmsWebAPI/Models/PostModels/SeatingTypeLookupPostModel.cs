using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class SeatingTypeLookupPostModel
    {
        public SeatingTypeLookupPostModel()
        {
            //  VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();
        }

        public int SeatingTypeId { get; set; }

        public string SeatingTypeName { get; set; } = null!;


        //  public virtual ICollection<VictimDetailsTransactionEntity> VictimDetailsTransactions { get; set; }
        public SeatingTypeLookupPostModel(SeatingTypeLookupEntity entity)
        {
            this.SeatingTypeId = entity.SeatingTypeId;
            this.SeatingTypeName = entity.SeatingTypeName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            SeatingTypeLookupEntity model = new SeatingTypeLookupEntity();
            model.SeatingTypeId = this.SeatingTypeId;
            model.SeatingTypeName = this.SeatingTypeName;
            return model as T;
        }
    }
}
