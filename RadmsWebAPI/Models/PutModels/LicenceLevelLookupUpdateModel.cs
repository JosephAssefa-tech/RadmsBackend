using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class LicenceLevelLookupUpdateModel
    {
        public LicenceLevelLookupUpdateModel()
        {
            //  VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int LeveloflicenceId { get; set; }

        public string LeveloflicenceName { get; set; } = null!;
        //  VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        public LicenceLevelLookupUpdateModel(LicenceLevelLookupEntity entity)
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
