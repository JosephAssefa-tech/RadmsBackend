using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class EmploymentStatusLookupPostModel
    {
        public EmploymentStatusLookupPostModel()
        {

            //   VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();

        }

        public int EmploymentStatusId { get; set; }

        public string EmploymentStatusName { get; set; } = null!;
        public EmploymentStatusLookupPostModel(EmploymentStatusLookupEntity entity)
        {
            this.EmploymentStatusId = entity.EmploymentStatusId;
            this.EmploymentStatusName = entity.EmploymentStatusName;

            //   VictimDetailsTransactions = new HashSet<VictimDetailsTransactionEntity>();

        }
        public T MapToViewEntity<T>() where T : class
        {
            EmploymentStatusLookupEntity entity = new EmploymentStatusLookupEntity();
            entity.EmploymentStatusId = this.EmploymentStatusId;
            entity.EmploymentStatusName = this.EmploymentStatusName;

            return entity as T;

        }
    }
}
