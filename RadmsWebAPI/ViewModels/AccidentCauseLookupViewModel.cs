using RadmsEntities;
using RadmsWebAPI.ViewModels.BaseModel;

namespace RadmsWebAPI.ViewModels
{
    public class AccidentCauseLookupViewModel:ViewBaseModel
    {

        public int AccidentCauseId { get; set; }
        public string AccidentCauseName { get; set; } = null!;
        // public virtual ICollection<AccidentDetailsTransactionViewModel>? AccidentDetailsTransactions { get; set; }
        
        public AccidentCauseLookupViewModel()
        {

        }
        public AccidentCauseLookupViewModel(AccidentCauseLookupEntity entity)
        {
            this.AccidentCauseId = entity.AccidentCauseId;
            this.AccidentCauseName = entity.AccidentCauseName;

        }

        public T MapToViewEntity<T>() where T : class
        {
            AccidentCauseLookupEntity entity=new AccidentCauseLookupEntity();
            entity.AccidentCauseId = this.AccidentCauseId;
            entity.AccidentCauseName = this.AccidentCauseName;

            return entity as T;

        }
    }
}
