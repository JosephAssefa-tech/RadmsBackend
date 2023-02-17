using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class AccidentCauseLookupPostModel
    {
        public int AccidentCauseId { get; set; }
        public string AccidentCauseName { get; set; } = null!;
        // public virtual ICollection<AccidentDetailsTransactionViewModel>? AccidentDetailsTransactions { get; set; }

        public AccidentCauseLookupPostModel()
        {

        }
        public AccidentCauseLookupPostModel(AccidentCauseLookupEntity entity)
        {
            AccidentCauseId = entity.AccidentCauseId;
            AccidentCauseName = entity.AccidentCauseName;

        }

        public T MapToViewEntity<T>() where T : class
        {
            AccidentCauseLookupEntity entity = new AccidentCauseLookupEntity();
            entity.AccidentCauseId = AccidentCauseId;
            entity.AccidentCauseName = AccidentCauseName;


            return entity as T;

        }
    }
}
