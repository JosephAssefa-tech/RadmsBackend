using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class AccidentSeverityLevelViewModel
    {
        public AccidentSeverityLevelViewModel()
        {
            //    AccidentDetailsTransactions = new HashSet<AccidentDetailsTransactionEntity>();
        }
        public int SeverityId { get; set; }
        public string SeverityType { get; set; } = null!;


        public AccidentSeverityLevelViewModel(SeverityLevelLookupEntity entity)
        {
            this.SeverityId = entity.SeverityId;
            this.SeverityType = entity.SeverityType;

        }
        public T MapToViewEntity<T>() where T : class
        {
            SeverityLevelLookupEntity entity = new SeverityLevelLookupEntity();
            entity.SeverityId = this.SeverityId;
            entity.SeverityType = this.SeverityType;


            return entity as T;

        }

    }
}
