using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class VehicleDefectLookupViewModel
    {
        public int VehicleDefectId { get; set; }

        public string VehicleDefectName { get; set; } = null!;

        public VehicleDefectLookupViewModel(VehicleDefectLookupEntity entity)
        {
           this.VehicleDefectId = entity.VehicleDefectId;   
           this.VehicleDefectName = entity.VehicleDefectName;
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
