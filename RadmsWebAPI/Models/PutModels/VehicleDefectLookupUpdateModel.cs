using RadmsEntities;

namespace RadmsWebAPI.Models.PutModels
{
    public class VehicleDefectLookupUpdateModel
    {
        public VehicleDefectLookupUpdateModel()
        {
            //   VehicleDetailsTransactions = new HashSet<VehicleDetailsTransactionEntity>();
        }


        public int VehicleDefectId { get; set; }

        public string VehicleDefectName { get; set; } = null!;

        //  public virtual ICollection<VehicleDetailsTransactionEntity> VehicleDetailsTransactions { get; set; }
        public VehicleDefectLookupUpdateModel(VehicleDefectLookupEntity model)
        {
            this.VehicleDefectId = model.VehicleDefectId;
            this.VehicleDefectName = model.VehicleDefectName;
        }
        public T MapToViewEntity<T>() where T : class
        {
            VehicleDefectLookupEntity entity = new VehicleDefectLookupEntity();
            entity.VehicleDefectId = this.VehicleDefectId;
            entity.VehicleDefectName = this.VehicleDefectName;
            return entity as T;
        }
    }
}
