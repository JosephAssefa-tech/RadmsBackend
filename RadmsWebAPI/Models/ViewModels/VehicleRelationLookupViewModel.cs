using RadmsEntities;

namespace RadmsWebAPI.Models.ViewModels
{
    public class VehicleRelationLookupViewModel
    {
        public int VehicleRelationId { get; set; }

        public string VehicleRelationName { get; set; } = null!;
        public VehicleRelationLookupViewModel()
        {

        }
        public VehicleRelationLookupViewModel(VehicleRelationLookupEntity entity)
        {
            this.VehicleRelationId= entity.VehicleRelationId;
            this.VehicleRelationName= entity.VehicleRelationName;

        }
        public T MapToViewEntity<T>() where T : class
        {
            VehicleRelationLookupEntity entity = new VehicleRelationLookupEntity();
            entity.VehicleRelationId = this.VehicleRelationId;
            entity.VehicleRelationName = this.VehicleRelationName;
            return entity as T;
        }
    }
}
