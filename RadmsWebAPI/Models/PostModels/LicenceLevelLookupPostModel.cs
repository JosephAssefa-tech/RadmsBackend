using RadmsEntities;

namespace RadmsWebAPI.Models.PostModels
{
    public class LicenceLevelLookupPostModel
    {
        public LicenceLevelLookupPostModel()
        {
            //  VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int LeveloflicenceId { get; set; }

        public string LeveloflicenceName { get; set; } = null!;
        //  VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        public LicenceLevelLookupPostModel(LicenceLevelLookupEntity entity)
        {
           this.LeveloflicenceId = entity.LeveloflicenceId;
            this.LeveloflicenceName = entity.LeveloflicenceName;
        }
        public T MapToViewEntity<T>() where T : class
        {
            LicenceLevelLookupEntity entity = new LicenceLevelLookupEntity();
            entity.LeveloflicenceId = this.LeveloflicenceId;
            entity.LeveloflicenceName = this.LeveloflicenceName;


            return entity as T;
        }
      }
}
