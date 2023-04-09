using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class LicenceLevelLookupViewModel
    {
        public int LeveloflicenceId { get; set; }

        public string LeveloflicenceName { get; set; } = null!;


        //  public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public LicenceLevelLookupViewModel(LicenceLevelLookupEntity entity)
        {
            //  VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
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
